namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise009;
    using TestMyCode.CSharp.API.Attributes;
    [Points("8-9")]
    public partial class ProgramTest
    {
        [Fact]
        public void ExampleShouldWork()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                StorageFacility facility = new StorageFacility();
                facility.Add("a14", "ice skates");
                facility.Add("a14", "ice hockey stick");
                facility.Add("a14", "ice skates");

                facility.Add("f156", "rollerblades");
                facility.Add("f156", "rollerblades");

                facility.Add("g63", "six");
                facility.Add("g63", "pi");

                foreach (string unit in facility.StorageUnits())
                {
                    Console.WriteLine(unit);
                }
                foreach (string item in facility.Contents("a14"))
                {
                    Console.WriteLine(item);
                }
                foreach (string item in facility.Contents("f156"))
                {
                    Console.WriteLine(item);
                }
                facility.Remove("f156", "rollerblades");
                foreach (string item in facility.Contents("f156"))
                {
                    Console.WriteLine(item);
                }
                facility.Remove("f156", "rollerblades");
                foreach (string unit in facility.StorageUnits())
                {
                    Console.WriteLine(unit);
                }
                Console.SetOut(stdout);
                string example = "a14\nf156\ng63\nice skates\nice hockey stick\nice skates\nrollerblades\nrollerblades\nrollerblades\na14\ng63\n";
                Assert.Equal(example, sw.ToString());
            }
        }

        [Fact]
        public void AddShouldAddAndContentsShouldFindIt()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                StorageFacility facility = new StorageFacility();
                facility.Add("a14", "ice skates");
                foreach (string item in facility.Contents("a14"))
                {
                    Console.WriteLine(item);
                }

                Console.SetOut(stdout);
                string example = "ice skates\n";
                Assert.Equal(example, sw.ToString());
            }
        }

        [Fact]
        public void AddShouldAddAndRemoveShouldRemoveOnlyOne()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                StorageFacility facility = new StorageFacility();
                facility.Add("a14", "ice skates");
                facility.Add("a14", "ice skates");
                facility.Remove("a14", "ice skates");
                foreach (string item in facility.Contents("a14"))
                {
                    Console.WriteLine(item);
                }

                Console.SetOut(stdout);
                string example = "ice skates\n";
                Assert.Equal(example, sw.ToString());
            }
        }
    }
}
