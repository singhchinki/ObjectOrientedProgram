var log = NLog.LogManager.GetCurrentClassLogger();
log.Info("Stock management calculation");
StockAccountMangement.StockInventoryMain json = new StockAccountMangement.StockInventoryMain();
json.jsonConvert(@"F:\BridgeLabzFellowship\ObjectOrientedProgram\StockAccountMangement\StockAccountMangement\StockInventory.json");