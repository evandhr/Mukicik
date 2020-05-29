using Mukicik_backend.Model;
using Mukicik_backend.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mukicik_backend.View
{
    public partial class testpurpose : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userSession"] != null)
            {
                using (Database1Entities db = new Database1Entities())
                {
                    /* string userName = Session["userSession"].ToString();
                    int userID = db.Users.Where(obj => obj.userName == userName).Select(x=>x.userID).FirstOrDefault(); 

                    test2.Text = userID.ToString();
                    test3.Text = userName; */
                }

            }

            using (Database1Entities db = new Database1Entities())
            {
            }
            TimeSpan todayTime = DateTime.Now.TimeOfDay;
            outputLabel2.Text = todayTime.ToString();
            outputLabel.Text = calendarTest.SelectedDate.ToString();
        }

        protected void UploadFile(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/resources/userProfilePicture/");

            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);
            }


            //Save the File to the Directory (Folder).
            fileUpload1.SaveAs(folderPath + Path.GetFileName(fileUpload1.FileName));

            //Display the Picture in Image control.
            image1.ImageUrl = "~/resources/userProfilePicture/" + Path.GetFileName(fileUpload1.FileName);
        }

        protected void button_gender_Click(object sender, EventArgs e)
        {
            string temp_gender = null;
            if (button_male != null) temp_gender = "male";
            if (button_female != null) temp_gender = "female";

            label_gender.Text = temp_gender;
            Response.Redirect("test.aspx");
        }

        protected void addCategory_click(object sender, EventArgs e)
        {
            /* string name = input_addCategory.Text; */
            /* categoryRepository.createCategory(name); */
        }
    }
}

/* bug1: clicking upload after a successful image upload and page refresh */
/* bug2: uploading a same file name, will replace previous uploaded file */