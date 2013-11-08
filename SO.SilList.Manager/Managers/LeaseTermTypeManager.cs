﻿using SO.SilList.Manager.DbContexts;
using SO.SilList.Manager.Interfaces;
using SO.SilList.Manager.Models.ValueObjects;
using EntityFramework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SO.SilList.Manager.Models.ViewModels;

namespace SO.SilList.Manager.Managers
{
    public class LeaseTermTypeManager : ILeasingTermTypeManager
    {

        public PropertyListingTypeVo get(int leaseTermTypeId)
        {
            using (var db = new MainDb())
            {
                var result = db.leaseTermType
                            .FirstOrDefault(L => L.propertyListingTypeId == leaseTermTypeId);

                return result;
            }
        }

        /// <summary>
        /// Get First Item
        /// </summary>
        public PropertyListingTypeVo getFirst()
        {
            using (var db = new MainDb())
            {
                var res = db.leaseTermType
                            .FirstOrDefault();

                return res;
            }
        }

        public LeaseTermTypeVm search(LeaseTermTypeVm input)
        {

            using (var db = new MainDb())
            {
                var query = db.leaseTermType
    
                            .OrderBy(b => b.name)
                            .Where(e => (input.isActive == null || e.isActive == input.isActive)
                                      && (e.name.Contains(input.keyword) || string.IsNullOrEmpty(input.keyword))
                             );
                input.paging.totalCount = query.Count();
                input.result = query
                             .Skip(input.paging.skip)
                             .Take(input.paging.rowCount)

                             .ToList();

                return input;
            }
        }


        public List<PropertyListingTypeVo> getAll(bool? isActive = true)
        {
            using (var db = new MainDb())
            {
                var list = db.leaseTermType
                             .Where(e => isActive == null || e.isActive == isActive)
                             .ToList();

                return list;
            }
        }

        public bool delete(int leaseTermTypeId)
        {
            using (var db = new MainDb())
            {
                var res = db.leaseTermType
                     .Where(e => e.propertyListingTypeId == leaseTermTypeId)
                     .Delete();
                return true;
            }
        }

        public PropertyListingTypeVo update(PropertyListingTypeVo input, int? leaseTermTypeId = null)
        {
            using (var db = new MainDb())
            {

                if (leaseTermTypeId == null)
                    leaseTermTypeId = input.propertyListingTypeId;

                var res = db.leaseTermType.FirstOrDefault(e => e.propertyListingTypeId == leaseTermTypeId);

                if (res == null) return null;

                input.created = res.created;
                input.createdBy = res.createdBy;
                db.Entry(res).CurrentValues.SetValues(input);


                db.SaveChanges();
                return res;

            }
        }

        public PropertyListingTypeVo insert(PropertyListingTypeVo input)
        {
            using (var db = new MainDb())
            {

                db.leaseTermType.Add(input);
                db.SaveChanges();

                return input;
            }
        }

        public int count()
        {
            using (var db = new MainDb())
            {
                return db.leaseTermType.Count();
            }
        }
    }
}
