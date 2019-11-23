﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Controllers
{
    class TrnStockCountLineController
    {
        // ============
        // Data Context
        // ============
        public Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        // =====================
        // List Stock-Count Line
        // =====================
        public List<Entities.TrnStockCountLineEntity> ListStockCountLine(Int32 stockCountId)
        {
            var stockCountLines = from d in db.TrnStockCountLines
                                  where d.StockCountId == stockCountId
                                  select new Entities.TrnStockCountLineEntity
                                  {
                                      Id = d.Id,
                                      StockCountId = d.StockCountId,
                                      ItemId = d.ItemId,
                                      ItemDescription = d.MstItem.ItemDescription,
                                      UnitId = d.UnitId,
                                      Unit = d.MstUnit.Unit,
                                      Quantity = d.Quantity,
                                      Cost = d.Cost,
                                      Amount = d.Amount
                                  };

            return stockCountLines.OrderByDescending(d => d.Id).ToList();
        }

        // ================
        // List Search Item
        // ================
        public List<Entities.MstItemEntity> ListSearchItem(String filter)
        {
            var items = from d in db.MstItems
                        where d.BarCode.Contains(filter)
                        || d.ItemDescription.Contains(filter)
                        || d.GenericName.Contains(filter)
                        select new Entities.MstItemEntity
                        {
                            Id = d.Id,
                            BarCode = d.BarCode,
                            ItemDescription = d.ItemDescription,
                            GenericName = d.GenericName,
                            OutTaxId = d.OutTaxId,
                            OutTax = d.MstTax1.Tax,
                            OutTaxRate = d.MstTax1.Rate,
                            UnitId = d.UnitId,
                            Unit = d.MstUnit.Unit,
                            Price = d.Price,
                            OnhandQuantity = d.OnhandQuantity
                        };

            return items.OrderBy(d => d.ItemDescription).ToList();
        }

        // ===========
        // Detail Item
        // ===========
        public Entities.MstItemEntity DetailSearchItem(String barcode)
        {
            var item = from d in db.MstItems
                       where d.BarCode.Equals(barcode)
                       select new Entities.MstItemEntity
                       {
                           Id = d.Id,
                           BarCode = d.BarCode,
                           ItemDescription = d.ItemDescription,
                           GenericName = d.GenericName,
                           OutTaxId = d.OutTaxId,
                           OutTax = d.MstTax1.Tax,
                           OutTaxRate = d.MstTax1.Rate,
                           UnitId = d.UnitId,
                           Unit = d.MstUnit.Unit,
                           Price = d.Price,
                           OnhandQuantity = d.OnhandQuantity
                       };

            return item.FirstOrDefault();
        }

        // ====================
        // Add Stock-Count Line
        // ====================
        public String[] AddStockCountLine(Entities.TrnStockCountLineEntity objStockCountLine)
        {
            try
            {
                var stockCount = from d in db.TrnStockCounts
                                 where d.Id == objStockCountLine.StockCountId
                                 select d;

                if (stockCount.Any() == false)
                {
                    return new String[] { "Stock-Count transaction not found.", "0" };
                }

                var item = from d in db.MstItems
                           where d.Id == objStockCountLine.ItemId
                           && d.IsLocked == true
                           select d;

                if (item.Any() == false)
                {
                    return new String[] { "Item not found.", "0" };
                }

                Data.TrnStockCountLine newStockCountLine = new Data.TrnStockCountLine
                {
                    StockCountId = objStockCountLine.StockCountId,
                    ItemId = objStockCountLine.ItemId,
                    UnitId = item.FirstOrDefault().UnitId,
                    Quantity = objStockCountLine.Quantity,
                    Cost = objStockCountLine.Cost,
                    Amount = objStockCountLine.Amount
                };

                db.TrnStockCountLines.InsertOnSubmit(newStockCountLine);
                db.SubmitChanges();

                return new String[] { "", "1" };
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // =======================
        // Update Stock-Count Line
        // =======================
        public String[] UpdateStockCountLine(Int32 id, Entities.TrnStockCountLineEntity objStockCountLine)
        {
            try
            {
                var stockCountLine = from d in db.TrnStockCountLines
                                     where d.Id == id
                                     select d;

                if (stockCountLine.Any())
                {
                    var stockCount = from d in db.TrnStockCounts
                                     where d.Id == objStockCountLine.StockCountId
                                     select d;

                    if (stockCount.Any() == false)
                    {
                        return new String[] { "Stock-Count transaction not found.", "0" };
                    }

                    var updateStockCountLine = stockCountLine.FirstOrDefault();
                    updateStockCountLine.Quantity = objStockCountLine.Quantity;
                    updateStockCountLine.Cost = objStockCountLine.Cost;
                    updateStockCountLine.Amount = objStockCountLine.Amount;
                    db.SubmitChanges();

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Stock-Count line not found.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // =======================
        // Delete Stock-Count Line
        // =======================
        public String[] DeleteStockCountLine(Int32 id)
        {
            try
            {
                var stockCountLine = from d in db.TrnStockCountLines
                                     where d.Id == id
                                     select d;

                if (stockCountLine.Any())
                {
                    var deleteStockCountLine = stockCountLine.FirstOrDefault();
                    db.TrnStockCountLines.DeleteOnSubmit(deleteStockCountLine);
                    db.SubmitChanges();

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Stock-Count line not found.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ========================
        // Barcode Stock-Count Line
        // ========================
        public String[] BarcodeStockCountLine(Int32 stockCountId, String barcode)
        {
            try
            {
                var stockCount = from d in db.TrnStockCounts
                                 where d.Id == stockCountId
                                 select d;

                if (stockCount.Any() == false)
                {
                    return new String[] { "Stock-Count transaction not found.", "0" };
                }

                var item = from d in db.MstItems
                           where d.BarCode.Equals(barcode)
                           && d.IsLocked == true
                           select d;

                if (item.Any() == false)
                {
                    return new String[] { "Item not found.", "0" };
                }

                Data.TrnStockCountLine newStockCountLine = new Data.TrnStockCountLine
                {
                    StockCountId = stockCountId,
                    ItemId = item.FirstOrDefault().Id,
                    UnitId = item.FirstOrDefault().UnitId,
                    Quantity = 1,
                    Cost = 0,
                    Amount = 0
                };

                db.TrnStockCountLines.InsertOnSubmit(newStockCountLine);
                db.SubmitChanges();

                return new String[] { "", "1" };
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }
    }
}