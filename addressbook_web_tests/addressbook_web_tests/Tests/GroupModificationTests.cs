using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : GroupTestBase
    {


        [Test]
        public void GroupModificationTest()
        {
            
     
            List<GroupData> oldGroups = GroupData.GetAll();
            //GroupData oldData = oldGroups[0];

            app.Navigator.GoToGroupsPage();
            app.Groups.Validate();

            app.Groups.Modify(oldGroups[0]);

            Assert.AreEqual(oldGroups.Count, app.Groups.GetGroupCount());

            List<GroupData> newGroups = GroupData.GetAll();
            //oldData.Name = newData.Name;
            //oldGroups.Sort();
            //newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

            foreach (GroupData group in newGroups)
            {
                if (group.Name == oldGroups[0].Name)
                {
                    Assert.AreEqual(newGroups, oldGroups);
                }
            }
            
            app.Auth.LogOut();
        
            
        }
    }
}
