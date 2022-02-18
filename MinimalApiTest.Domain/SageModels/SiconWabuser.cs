using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabuser
    {
        public long SiconWabuserId { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public bool? Enabled { get; set; }
        public bool? AccessSop { get; set; }
        public bool? AccessPop { get; set; }
        public bool? AccessPutAway { get; set; }
        public bool? AccessJobIssue { get; set; }
        public bool? AccessInternalIssue { get; set; }
        public bool? AccessStocktake { get; set; }
        public bool? AccessWop { get; set; }
        public bool? AccessKitting { get; set; }
        public bool? AccessAddStock { get; set; }
        public int? AllowQuantityTypeLimit { get; set; }
        public bool? AccessSopreturns { get; set; }
        public bool? AccessPopdespatch { get; set; }
        public bool? AccessWriteOffStock { get; set; }
        public bool? AccessTilted { get; set; }
        public bool? AccessStockTransferDespatch { get; set; }
        public bool? AccessStockTransferReceipt { get; set; }
        public bool? AllowOverReceive { get; set; }
        public bool? AccessInspection { get; set; }
        public bool? AccessReplenishment { get; set; }
        public bool? AccessWavePick { get; set; }
        public bool? AccessWavePack { get; set; }
        public bool? AccessDynamicStocktake { get; set; }
        public bool? AccessHireTransfer { get; set; }
        public bool? AccessZonePicker { get; set; }
        public bool? AccessZonePacker { get; set; }
        public string? DefaultLabelPrinter { get; set; }
        public string? DefaultPackingListPrinter { get; set; }
        public string? DefaultDespatchPrinter { get; set; }
        public string? DefaultInvoicePrinter { get; set; }
        public long? CurrentPickForeignId { get; set; }
        public DateTime? CurrentPickDate { get; set; }
        public int? CurrentPickTypeId { get; set; }
        public string? CurrentPickDescription { get; set; }
        public bool? AllowPicking { get; set; }
        public bool? AllowPacking { get; set; }
        public bool? AllowDespatching { get; set; }
        public bool? AllowChangeBin { get; set; }
        public bool? AllowAddSopline { get; set; }
        public bool? ShowExpectedQtyOnDynStocktake { get; set; }
        public string? SopanalysisCode1Filter { get; set; }
        public string? SopanalysisCode2Filter { get; set; }
        public string? SopanalysisCode3Filter { get; set; }
        public string? SopanalysisCode4Filter { get; set; }
        public string? SopanalysisCode5Filter { get; set; }
        public string? SopanalysisCode6Filter { get; set; }
        public string? SopanalysisCode7Filter { get; set; }
        public string? SopanalysisCode8Filter { get; set; }
        public string? SopanalysisCode9Filter { get; set; }
        public string? SopanalysisCode10Filter { get; set; }
        public string? SopanalysisCode11Filter { get; set; }
        public string? SopanalysisCode12Filter { get; set; }
        public string? SopanalysisCode13Filter { get; set; }
        public string? SopanalysisCode14Filter { get; set; }
        public string? SopanalysisCode15Filter { get; set; }
        public string? SopanalysisCode16Filter { get; set; }
        public string? SopanalysisCode17Filter { get; set; }
        public string? SopanalysisCode18Filter { get; set; }
        public string? SopanalysisCode19Filter { get; set; }
        public string? SopanalysisCode20Filter { get; set; }
        public string? SoppriorityFilter { get; set; }
        public int? SoppickPackFilter { get; set; }
        public string? SopcountryCodeFilter { get; set; }
        public bool? SoptodaySelectedFilter { get; set; }
        public DateTime? LastLoginDateTime { get; set; }
        public DateTime? LastLogoutDateTime { get; set; }
        public string? LastLoginDevice { get; set; }
        public bool? AllowCreatingNewBins { get; set; }
    }
}
