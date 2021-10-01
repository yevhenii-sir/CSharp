using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

using Newtonsoft.Json;

namespace ParseCurrency
{
     class Currency
     {
          public string ccy { get; set; }
          public string base_ccy { get; set; }
          public decimal buy { get; set; }
          public decimal sale { get; set; }
     }
     
     class MainClass
     {
          static void Main(string[] args)
          {
               string myUrl = "https://api.privatbank.ua/p24api/pubinfo?exchange&json&coursid=11";

               WebClient client = new WebClient();
               client.Encoding = System.Text.Encoding.UTF8;
               ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 |
                                                      SecurityProtocolType.Tls;
               try
               {
                    string jsonString = Encoding.UTF8.GetString(client.DownloadData(myUrl));
                    List<Currency>? ccur = JsonConvert.DeserializeObject<List<Currency>>(jsonString);
                    
                    Console.Write("1 - Покупка\n" +
                                  "2 - Продажа\n" +
                                  "Выберете: ");
                    string menu = Console.ReadLine();
                    
                    Console.Write("Введите сумму: ");
                    decimal money = Convert.ToDecimal(Console.ReadLine());
                    
                    Console.WriteLine("------------------------------------");
                    
                    switch (menu)
                    {
                         case "1":
                         {
                              foreach (var variableCurrency in ccur)
                              {
                                   Console.WriteLine($"Курс покупки: {variableCurrency.ccy} - {variableCurrency.buy:0.00}");
                                   Console.Write($"За {money:#.00} UAH вы получите ");
                                   Console.Write(variableCurrency.ccy == "BTC"
                                        ? $"{money / (variableCurrency.buy * ccur.Find(x => x.ccy == variableCurrency.base_ccy)!.buy):0.00000000}"
                                        : $"{money / variableCurrency.buy:0.00}");
                                   Console.WriteLine($" {variableCurrency.ccy}");
                                   Console.WriteLine("------------------------------------");
                              }
                              break;
                         }
                         case "2":
                         {
                              foreach (var variableCurrency in ccur)
                              {
                                   Console.WriteLine($"Курс продажи: {variableCurrency.ccy} - {variableCurrency.sale:0.00}");
                                   Console.Write($"За {money:#.00} UAH вы получите ");
                                   Console.Write(variableCurrency.ccy == "BTC"
                                        ? $"{money / (variableCurrency.buy * ccur.Find(x => x.ccy == variableCurrency.base_ccy)!.sale):0.00000000}"
                                        : $"{money / variableCurrency.sale:0.00}");
                                   Console.WriteLine($" {variableCurrency.ccy}");
                                   Console.WriteLine("------------------------------------");
                              }
                              break;
                         }
                    }
               }
               catch
               {
                    Console.WriteLine("Error :(");
               }
          }
     }
}