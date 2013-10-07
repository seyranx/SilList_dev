﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SO.SilList.Manager.Managers;
using SO.SilList.Manager.Models.ValueObjects;
using SO.SilList.Manager.Models.ViewModels;
using SO.SilList.Utility.Classes;

namespace SO.SilList.Tests.Managers
{
    [TestClass]
    public class ListingManagerTest
    {
        private ListingManager listingManager = new ListingManager();

        [TestMethod]
        public void searchTest()
        {
            var vm = new ListingVm();
            vm.paging.pageNumber = 4;
            vm.isActive = true;

            var res = listingManager.search(vm);

            if (res != null)
            {
                Assert.IsTrue(true);
            }
            else 
                Assert.IsTrue(false);
        }

        [TestMethod]
        public void getAllTest()
        {

            var res = listingManager.getAll(null);

            if (res != null)
            {
                Assert.IsTrue(true);
            }
            else Assert.IsTrue(false);
        }


        [TestMethod]
        public void insertDeleteTest()
        {
            var vo = new ListingVo();
            //vo.title = 'listing title';
            vo.createdBy = 3;

            var result = listingManager.insert(vo);
            var result2 = listingManager.get(result.listingId);

            listingManager.delete(result.listingId);

            var result3 = listingManager.get(result.listingId);

            if (result != null && result2 != null && result3 == null && result2.listingId != Guid.Empty)
            {
                Assert.IsTrue(true);
            }
            else
                Assert.IsTrue(false);
        }
    }
}
