using Microsoft.EntityFrameworkCore;
using Valor.Models;

namespace Valor.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ValorContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ValorContext>>()))
            {
                if (context == null || context.Operators == null)
                {
                    throw new ArgumentNullException("Null!ValorContext!");
                }

              
                if (context.Operators.Any())
                {
                    return;   //DB Seeded
                }

                context.Operators.AddRange(
                    new Operator
                    {
                        Operator_FirstName = "Justin",
                        Operator_LastName = "Jefferson",
                        Email = "JJ@valor.com",
                        Wells = new List<Well> {
                    new Well 
                        {   
                        Well_Name = "Lucky Seven Ranch Lease #1",
                        Flow_Rate = 78,
                        Storage_Capacity = 10,
                        Reports = new List<Report>{
                    new Report{
                        ReportParagraph = "Leaking Produced Water"
                        }
                            }
                        },
                      new Well 
                        {   
                        Well_Name = "Lucky Seven Lease #2",
                        Flow_Rate = 12,
                        Storage_Capacity = 100,
                        Reports = new List<Report>{
                    new Report{
                        ReportParagraph = "No danger signs!"
                        }
                            }
                        }


                        }
                   
                    },

                    new Operator
                    {
                        Operator_FirstName = "Tyreek",
                        Operator_LastName = "Hill",
                        Email = "THill@valor.com",
                     Wells = new List<Well> {
                    new Well 
                        {   
                        Well_Name = "Lucky Seven Ranch Lease #3",
                        Flow_Rate = 24,
                        Storage_Capacity = 200,
                        Reports = new List<Report>{
                    new Report{
                        ReportParagraph = "No issues found"
                        }
                            }
                        },
                      new Well 
                        {   
                        Well_Name = "Lucky Seven Lease #4",
                        Flow_Rate = 68,
                        Storage_Capacity = 200,
                        Reports = new List<Report>{
                    new Report{
                        ReportParagraph = "Lack of lubrication"
                        }
                            }
                        }


                        }
                    },

                    new Operator
                    {
                        Operator_FirstName = "Randy",
                        Operator_LastName = "Moss",
                        Email = "RandyMoss@valor.com",
                     Wells = new List<Well> {
                    new Well 
                        {   
                        Well_Name = "Rocking Z Ranch Lease #1",
                        Flow_Rate = 24,
                        Storage_Capacity = 200,
                        Reports = new List<Report>{
                    new Report{
                        ReportParagraph = "No issues found"
                        }
                            }
                        },
                      new Well 
                        {   
                        Well_Name = "Rocking Z Ranch Lease #2",
                        Flow_Rate = 68,
                        Storage_Capacity = 200,
                        Reports = new List<Report>{
                    new Report{
                        ReportParagraph = "No Issues Found"
                        }
                            }
                        }


                        }
                    },
                    new Operator
                    {
                        Operator_FirstName = "Tom",
                        Operator_LastName = "Brady",
                        Email = "TomBrady@valor.com",
                     Wells = new List<Well> {
                    new Well 
                        {   
                        Well_Name = "Rocking Z Ranch Lease #3",
                        Flow_Rate = 24,
                        Storage_Capacity = 200,
                        },
                      new Well 
                        {   
                        Well_Name = "Rocking Z Ranch Lease #4",
                        Flow_Rate = 68,
                        Storage_Capacity = 200
                        }
                     }
                    },
                     new Operator
                    {
                        Operator_FirstName = "Eli",
                        Operator_LastName = "Manning",
                        Email = "EliManning@valor.com",
                     Wells = new List<Well> {
                    new Well 
                        {   
                        Well_Name = "Rocking Z Ranch Lease #5",
                        Flow_Rate = 12,
                        Storage_Capacity = 202,
                        },
                      new Well 
                        {   
                        Well_Name = "Rocking Z Ranch Lease #6",
                        Flow_Rate = 63,
                        Storage_Capacity = 250
                        }
                     }
                    },
                     new Operator
                    {
                        Operator_FirstName = "Patrick",
                        Operator_LastName = "Mahomes",
                        Email = "PatrickMahomes@valor.com",
                     Wells = new List<Well> {
                    new Well 
                        {   
                        Well_Name = "Alamo Lease #1",
                        Flow_Rate = 10,
                        Storage_Capacity = 205,
                        },
                      new Well 
                        {   
                        Well_Name = "Alamo Lease #2",
                        Flow_Rate = 60,
                        Storage_Capacity = 123
                        }
                     }
                    },
                     new Operator
                    {
                        Operator_FirstName = "JJ",
                        Operator_LastName = "Watts",
                        Email = "JJWATTS@valor.com",
                     Wells = new List<Well> {
                    new Well 
                        {   
                        Well_Name = "Alamo Lease #3",
                        Flow_Rate = 10,
                        Storage_Capacity = 205,
                        },
                      new Well 
                        {   
                        Well_Name = "Alamo Lease #4",
                        Flow_Rate = 60,
                        Storage_Capacity = 123
                        }
                     }
                    },
                    new Operator
                    {
                        Operator_FirstName = "TJ",
                        Operator_LastName = "Watts",
                        Email = "TJWATTS@valor.com",
                     Wells = new List<Well> {
                    new Well 
                        {   
                        Well_Name = "Alamo Lease #5",
                        Flow_Rate = 10,
                        Storage_Capacity = 205,
                        },
                      new Well 
                        {   
                        Well_Name = "Alamo Lease #6",
                        Flow_Rate = 60,
                        Storage_Capacity = 123
                        }
                     }
                    },
                     new Operator
                    {
                        Operator_FirstName = "Nick",
                        Operator_LastName = "Bosa",
                        Email = "NickBosa@valor.com",
                     Wells = new List<Well> {
                    new Well 
                        {   
                        Well_Name = "Alamo Lease #7",
                        Flow_Rate = 100,
                        Storage_Capacity = 205,
                        },
                      new Well 
                        {   
                        Well_Name = "Alamo Lease #8",
                        Flow_Rate = 20,
                        Storage_Capacity = 127
                        }
                     }
                    },
                     new Operator
                    {
                        Operator_FirstName = "Joey",
                        Operator_LastName = "Bosa",
                        Email = "JoeyBosa@valor.com",
                     Wells = new List<Well> {
                    new Well 
                        {   
                        Well_Name = "Alamo Lease #9",
                        Flow_Rate = 15,
                        Storage_Capacity = 128,
                        },
                      new Well 
                        {   
                        Well_Name = "Alamo Lease #10",
                        Flow_Rate = 20,
                        Storage_Capacity = 122
                        }
                     }
                    },
                    new Operator
                    {
                        Operator_FirstName = "Joe",
                        Operator_LastName = "Thuney",
                        Email = "JoeThuney@valor.com",
                     Wells = new List<Well> {
                    new Well 
                        {   
                        Well_Name = "Burn Ranch Lease #1",
                        Flow_Rate = 20,
                        Storage_Capacity = 200,
                        },
                      new Well 
                        {   
                        Well_Name = "Burn Ranch Lease #2",
                        Flow_Rate = 20,
                        Storage_Capacity = 115
                        }
                     }
                    },
                     new Operator
                    {
                        Operator_FirstName = "Kyler",
                        Operator_LastName = "Murray",
                        Email = "KylerMurray@valor.com",
                     Wells = new List<Well> {
                    new Well 
                        {   
                        Well_Name = "Burn Ranch Lease #3",
                        Flow_Rate = 20,
                        Storage_Capacity = 200,
                        },
                      new Well 
                        {   
                        Well_Name = "Burn Ranch Lease #4",
                        Flow_Rate = 20,
                        Storage_Capacity = 115
                        }
                     }
                    },
                     new Operator
                    {
                        Operator_FirstName = "Justin",
                        Operator_LastName = "Herbert",
                        Email = "JustinHerbert@valor.com",
                     Wells = new List<Well> {
                    new Well 
                        {   
                        Well_Name = "Burn Ranch Lease #5",
                        Flow_Rate = 20,
                        Storage_Capacity = 200,
                        },
                      new Well 
                        {   
                        Well_Name = "Burn Ranch Lease #6",
                        Flow_Rate = 20,
                        Storage_Capacity = 115
                        }
                     }
                    },
                    new Operator
                    {
                        Operator_FirstName = "Marvin",
                        Operator_LastName = "Harrison",
                        Email = "MarvinHarrison@valor.com",
                     Wells = new List<Well> {
                    new Well 
                        {   
                        Well_Name = "Burn Ranch Lease #7",
                        Flow_Rate = 20,
                        Storage_Capacity = 200,
                        },
                      new Well 
                        {   
                        Well_Name = "Burn Ranch Lease #8",
                        Flow_Rate = 20,
                        Storage_Capacity = 115
                        }
                     }
                    },
                       new Operator
                    {
                        Operator_FirstName = "Malik",
                        Operator_LastName = "Nabers",
                        Email = "MalikNabers@valor.com",
                     Wells = new List<Well> {
                    new Well 
                        {   
                        Well_Name = "Burn Ranch Lease #9",
                        Flow_Rate = 20,
                        Storage_Capacity = 200,
                        },
                      new Well 
                        {   
                        Well_Name = "Burn Ranch Lease #10",
                        Flow_Rate = 20,
                        Storage_Capacity = 115
                        }
                     }
                    }






































                );
                context.SaveChanges();
            }
        }
    }
}



