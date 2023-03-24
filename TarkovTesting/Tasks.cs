using System.Diagnostics;
using Tarkov;
using Tarkov.Entities;

namespace TarkovTesting
{
    [TestClass]
    public class Tasks
    {
        [TestMethod]
        public async Task TestGetTasksAsync()
        {
            Api tarkov = Api.GetTarkov();
            Quest[] usec = await tarkov.GetTasksAsync(false, "USEC");
            Console.WriteLine(usec.Length + " tasks for USEC.");
            Assert.IsNotNull(usec);

            Quest[] bear = await tarkov.GetTasksAsync(false, "BEAR");
            Console.WriteLine(bear.Length + " tasks for BEAR.");
            Assert.IsNotNull(bear);
        }

        [TestMethod]
        public async Task TestGetTasksReducedAsync()
        {
            Api tarkov = Api.GetTarkov();
            Quest[] usec = await tarkov.GetTasksAsync(true, "USEC");
            Console.WriteLine(usec.Length + " tasks for USEC.");
            Assert.IsNotNull(usec);

            Quest[] bear = await tarkov.GetTasksAsync(true, "BEAR");
            Console.WriteLine(bear.Length + " tasks for BEAR.");
            Assert.IsNotNull(bear);
        }

        [TestMethod]
        public async Task TestGetTaskAsync()
        {
            Api tarkov = Api.GetTarkov();
            Quest task = await tarkov.GetTaskAsync("5967733e86f774602332fc84");
            Assert.IsNotNull(task);            
        }
    }
}