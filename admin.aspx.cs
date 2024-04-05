using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Page load logic here
    }

    private void ToggleVisibility(bool showGrid1, bool showGrid2, bool showGrid3, string labelText, bool showDetails1, bool showDetails2, bool showDetails3)
    {
        GridView1.Visible = showGrid1;
        GridView2.Visible = showGrid2;
        GridView3.Visible = showGrid3;
        Label1.Text = labelText;
        Label1.Visible = true;
        DetailsView1.Visible = showDetails1;
        DetailsView2.Visible = showDetails2;
        DetailsView3.Visible = showDetails3;
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        ToggleVisibility(true, false, false, "Student Summary", true, false, false);
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        ToggleVisibility(false, true, false, "College Summary", false, true, false);
    }

    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        ToggleVisibility(false, false, true, "Company Summary", false, false, true);
    }

    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        Session.Clear();
        Response.Redirect("adminlogin.aspx");
    }
}