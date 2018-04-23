﻿using System.Windows.Forms;
using DevExpress.Data.Utils.ServiceModel;
using DevExpress.XtraReports.Service;
using DevExpress.XtraReports.UI;
using ReportLibrary;

namespace ReportsSample.Web {
    [SilverlightFaultBehavior]
    public class ReportService : DevExpress.XtraReports.Service.ReportService {
        protected override void RegisterDataSources(XtraReport report, string reportName) {
            report.RegisterDataSourceName("Products", report.DataSource);
        }
        protected override void FillDataSources(XtraReport report, string reportName, bool isDesignActive) {
            var bindingSource = (BindingSource)report.GetDataSourceByName("Products");
            bindingSource.DataSource = new NorthwindEntities().Products;
        }
    }
}