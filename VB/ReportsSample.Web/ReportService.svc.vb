Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.Data.Utils.ServiceModel
Imports DevExpress.XtraReports.Service
Imports DevExpress.XtraReports.UI
Imports ReportLibrary

Namespace ReportsSample.Web
	<SilverlightFaultBehavior> _
	Public Class ReportService
		Inherits DevExpress.XtraReports.Service.ReportService
		Protected Overrides Sub RegisterDataSources(ByVal report As XtraReport, ByVal reportName As String)
			report.RegisterDataSourceName("Products", report.DataSource)
		End Sub
		Protected Overrides Sub FillDataSources(ByVal report As XtraReport, ByVal reportName As String, ByVal isDesignActive As Boolean)
			Dim bindingSource = CType(report.GetDataSourceByName("Products"), BindingSource)
			bindingSource.DataSource = New NorthwindEntities().Products
		End Sub
	End Class
End Namespace
