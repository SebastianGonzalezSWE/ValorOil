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
                    return;   //Seeded DB
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
                    }

                );
                context.SaveChanges();
            }
        }
    }
}



