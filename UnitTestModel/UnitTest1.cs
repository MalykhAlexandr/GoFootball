using System;
using System.Collections.Generic;
using System.IO;
using GoFootball;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class SeralizationTests
    {
        [TestMethod]
        public void End2EndSerializationTest()
        {
            var dto = new RideApplicationDto
            {
                Filled = DateTime.Now,
                FullName = "Alexandr Malykh",
                Citizenship = "Russian",
                Age = 19,
                Height = 178,
                Weight = 60,
                AgeStartCareer = 15,
                ExperienceInFootball = 3,
                Position = Position.Goalkeeper,
                WorkingLeg = WorkingLeg.Right,
                WeakSides = WeakSides.Endurance,
                Strengths = Strengths.Reaction,

                Traums = new List<Trauma>()
                { 
                new Trauma
                {
                    CountTraums = 0,
                    TimeTraums = 0,
                    TraumаNow = false,
                    Type = TraumaTypes.None
                }
            }
            };
            var tempFileName = Path.GetTempFileName();
            try
            {
                RideDtoHelper.WriteToFile(tempFileName, dto);
                var readDto = RideDtoHelper.LoadFromFile(tempFileName);
                Assert.AreEqual(dto.Filled, readDto.Filled);
            }
            finally
            {
                File.Delete(tempFileName);
            }
        }
    }
}

