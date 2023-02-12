As my time comes to a close with The Tech Academy, I want to offer a detailed explanation of the education earned in the Live Project for the C# and .NET Boot 
Camp.  First, the Live Project is intended to cumulate much or all of the knowledge gained in the whole Boot Camp.  Secondly, the Live project is in the context 
of a real-life development team environment.  The scope of work for my Live Project experience aimed at a client, with demand for a Back End setup to accommodate 
data entry and updates without requiring Code Based Html additions/changes.  The customer was a Theatre and there was an existing MVC framework which each developer
took a specific piece of.  My particular contribution pertained to the Events Calendar controller and respective views.  The general overview of Calendar Events 
portion of the website included building a code first database to house the information entries, build a model of views and a controller to add new features to the 
existing website.  The intent was to make User Forms that would accommodate the information needing entry to the website.


In the following scenarios, I will identify each with a preface of Front-End or Back-End referencing the specific scenario gaol.

	Back-End:  Building Data Entity Model and scaffolding CRUD Pages

		This Story introduced the core of the future work.  I received a Schema for generating a class which would produce a DataBase on a pre-determined 
		SQL Server accessible to other parts of the Web MVC App. Per the code snippet below, as well as adding a Db Set Command in the Identity controller. 
 

			![alt text](https://github.com/TRK360/C_Sharp-Projects/commit/4856212f2f5495149df5054f52d1f8023cf977b8)

		After confirming that the DataBase table was created with all of the proper Schema elements, nullables, primary key, etc. I then added a new 
		scaffolded item, selecting the MVC pre-determined views and was able to successfully generate several views and a controller all of which communicated 
		properly to the DataBase.


	Front-End:  Styling Create and Edit Pages

		This Story applied my CSS skills to modify the format of each of the elements pre-set by the scaffolding mentioned above.  I needed to create a 
		container class for all page elements, I then had to add several classes to modify elements such as input field border colors, font colors while 
		focused versus inactive all whilst adhering to a customer color scheme.  Please see some of the .CSS noted below.
		
			!(https://user-images.githubusercontent.com/117139528/218326366-99f30476-f643-4500-be74-14da9ee94bbe.jpg)
	
			
			!https://user-images.githubusercontent.com/117139528/218326386-eeb5948c-8911-4925-b294-069c048fe8af.jpg

	Front-End:  Styling Index Page and Reformatting Table Layout

		This Story rather drastically altered the Html and Css for the Index page.  The basic information provided as a result of the scaffolding was 
		formatted into a table which organized the respecive items in a manner disagreeable to the customer's needs.  It required the below noted Back-End 
		changes as well as some If rule logic built into the Cshtml of the view page.  Please see code snippet below to control which information was 
		displayed.

			https://user-images.githubusercontent.com/117139528/218326380-412b29ac-41a5-4c37-85ef-e4324f66e6bf.jpg

		
		After updating the Back-End Items as well as a few of the front end itmes to control the end view result, I applied some CSS specifically to the 
		table contents as well as header elements.



	Back-End:  Adding Description Parameter to initial Database and Updating Controller

		This Story introduced a change to the original database.  I needed to dive into the class and add a parameter for Descriptions, and then update 
		the view controller to pass the additional parameter as was required.  The first story Back-End code snippet demonstrates the class that was later
		modified.
			


The Live Project experience introduced several additional forms of training beyond the specifics of Code Syntax and Development process basics.  Utilizing Azure 
DevOps via their web portal, whilst also using a server on Discord to manage day to day team communications, a much more solid comprehension of how a Dev team 
behaves and functions was learned.  Furthermore, frequent use of Git Changes, commits, merges and the necessary consciensciousness of other people's work really 
drove home the idea of version control.  Additionally, several new research tools were communicated and shared amongst the group, this notably increased my 
efficiency during the live project.  Finally, with my personal background in working with, managing and directing large team efforts in fields of Architecture, 
Mechanical Engineering and Facility/Plant Management, the sense of respect to obligations and deadlines demonstrated through the SCRUM management philosophy that 
was demonstrated during the Live Project was very impactful in itself. 
Footer
© 2023 GitHub, Inc.
Footer navigation
Terms
Privacy
Security
Status
Docs
Contact GitHub
Pricing
API
Training
Blog
About
