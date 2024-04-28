using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Diagnostics;

namespace LogLoader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String fajl_neve = "";
            if (args.Length == 0)
            {
                System.Console.WriteLine("Nincs megadva a paraméter! Helyes sorrend: -InputFile FÁJL_NEVE");
            }
            else
            {
                if (args[0] == "-InputFile")
                {
                    if (args.Length < 2)
                    {
                        System.Console.WriteLine("Nem adtad meg a fájl nevét! Helyes sorrend: -InputFile FÁJL_NEVE");
                    }
                    else
                    {
                        fajl_neve = String.Concat(".\\", args[1]);
                    }
                }
                else
                {
                    System.Console.WriteLine("Hibás az első paraméter! Helyes sorrend: -InputFile FÁJL_NEVE");
                }
            }
            var builder = WebApplication.CreateBuilder(args);
            SQL.ConnectionString = builder.Configuration.GetConnectionString("SQL");
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddDbContext<SQL>(a =>
            {
                a.UseSqlServer(SQL.ConnectionString);
            });
            builder.Services.AddHttpClient();
            builder.Services.AddHttpContextAccessor();
            SQL dbContext;
            var app = builder.Build();
            int saved = 0;
            using (var scope = app.Services.CreateScope())
            {
                dbContext = scope.ServiceProvider.GetService<SQL>();
                if (!dbContext.Database.CanConnect())
                {
                    throw new Exception("HIBA!");
                }
                else
                {
                    try
                    {
                        if (fajl_neve != "")
                        {
                            string[] csv = File.ReadAllLines(fajl_neve);
                            List<LogEntry> logEntries = new List<LogEntry>();
                            string first = csv[0];
                            int ping = 0;
                            for (int i = 0; i < csv.Length; i++)
                            {
                                string[] splitted = csv[i].Split(';');


                                try
                                {
                                    dbContext.LogEntries.AddAsync(new LogEntry()
                                    {
                                        Id = int.Parse(splitted[0]),
                                        CorrelationId = Guid.Parse(splitted[1]),
                                        DataUtc = DateTime.Parse(splitted[2]),
                                        Thread = int.Parse(splitted[3]),
                                        Level = splitted[4],
                                        Logger = splitted[5],
                                        Message = splitted[6],
                                        Exception = splitted[7]
                                    });
                                    dbContext.SaveChanges();
                                    saved++;
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Nem menthető");
                                }
                            }
                            Console.WriteLine("Fájl neve: systemlog.csv");
                            Console.WriteLine("Fájlban lévő sorok száma: " + (logEntries.Count + 1));
                            Console.WriteLine("Beolvasott sorok száma: " + logEntries.Count);
                            Console.WriteLine("Eltárolt sorok száma: " + saved);
                        }
                        else
                        {
                            Console.WriteLine("Nincs megadva fájl a beolvasáshoz!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());

                    }
                }
            }
        }
    }
}
