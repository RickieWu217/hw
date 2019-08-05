using DevExtremeMvcApp2.Models;
using DevExtremeMvcApp2.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevExtremeMvcApp2
{
    public partial class CrystalReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            CrystalReportViewer1.ToolPanelView = CrystalDecisions.Web.ToolPanelViewType.None;
            CrystalReport1 crystalReport = new CrystalReport1();
            if (Request["page"]!=null && Request["page"].ToString() == "page1")
            {
                crystalReport.SetDataSource(SampleData.Persons.Where(r => r.PersonName.StartsWith("廖")));
            }
            else
            {
                crystalReport.SetDataSource(SampleData.Persons.Where(r => r.PersonAddress.Contains("台中市")));

            }

            
            CrystalReportViewer1.ReportSource = crystalReport;
            CrystalReportViewer1.RefreshReport();
        }
    }
}