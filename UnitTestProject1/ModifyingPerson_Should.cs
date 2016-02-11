using NUnit.Framework;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using System.Linq;
using System.Collections.Generic;

namespace WhiteSampleTests
{
    [TestFixture]
    public class ModifyingPerson_Should
    {
           
        [Test]
        public void ChangeUserLastName()
        {
            List<Window> windowList = Desktop.Instance.Windows();

            Window windowUnderTest = windowList.SingleOrDefault(x => x.Id.Contains("MainWindow"));

            windowUnderTest.DrawHighlight();
        }
    }
    //ToDo: Add page object pattern via factory
}
