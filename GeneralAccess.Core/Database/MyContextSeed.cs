using GeneralAccess.Core.Database;
using GeneralAccess.Entities;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogDemo.Infrastructure.Database
{
    public class MyContextSeed
    {
        public static async Task SeedAsync(MyContext myContext,
            ILoggerFactory loggerFactory, int retry = 0)
        {
            int retryForAvailability = retry;
            try
            {
                if (!myContext.AuthIcons.Any())
                {
                    myContext.AuthIcons.AddRange(
                        new List<AuthIcon> {
                            new AuthIcon{
                                IconCode="Icon_1",
                                Description="Description_Icon_1",
                                CreatedOn=DateTime.Now
                            },
                            new AuthIcon{
                                IconCode="Icon_2",
                                Description="Description_Icon_2",
                                CreatedOn=DateTime.Now
                            },
                            new AuthIcon{
                                IconCode="Icon_3",
                                Description="Description_Icon_3",
                                CreatedOn=DateTime.Now
                            },
                            new AuthIcon{
                                IconCode="Icon_4",
                                Description="Description_Icon_4",
                                CreatedOn=DateTime.Now
                            }
                        });
                    await myContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                if (retryForAvailability < 10)
                {
                    retryForAvailability++;
                    var logger = loggerFactory.CreateLogger<MyContextSeed>();
                    logger.LogError(ex.Message);
                    await SeedAsync(myContext, loggerFactory, retryForAvailability);
                }
            }
        }
    }
}
