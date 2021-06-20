# SEN_ExamPractice
Question:
Practice: Software Engineering 381
Date: 2021-05-12
Total: 100 Marks

Duration: 180 Minutes
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Page 1 of 5
The repository contains database backup, sql script for creatting database and C# Windows Application Solution. The database
must be used to construct the system described in this paper. The solution must be constructed as a VisualStudio project in main GitHub branch.
The database is mapped into VisualStudio project and accessed through the Server Explorer. 
The database contains diagrams to demonstrate its structure. 
Please change DataSource under class DBAccess, make sure it is mapped to your local machine before running the solution

Paper Instructions.
You are required to create a diary management system for persons that work on different teams of 
the same company. The solution must be implemented as a four-layer application. The data layer is 
supplied and found in the Diary database in the Database subdirectory. The implementation of the 
database may not be changed. You may manipulate the data in the database tables, but may not 
alter or add tables in any way. (The database contains design diagrams to show relationships
between the tables.)
You will need to build the presentation layer, business logic layer, and data access layer of the 
application. The application must be constructed as an object-oriented system. Marks will be 
allocated for the correct use of encapsulation, inheritance and polymorphism; and for the correct 
choices with regard to layers of abstraction and appropriate separation of responsibilities. Proper 
naming standards must be adhered to.
Screen samples shown are samples only. The system may be built using Windows forms. More 
general instructions are specified on page 4 of this paper.
Persons:
• Search for a person by filling in any fields and clicking the Search button. If a unique record is 
found, the form is populated with that record’s data. If more than one record matches the 
search criteria, a search results form pops up from which the user selects the required record, 
whose details are then used to populate this form.
• Whenever a list of persons is presented anywhere in the application (e.g. with search results 
or on the team form in the next section), it must be sorted – first by surname, then first Practice: Software Engineering 381
name, other names and finally suffix, if required to resolve the sort order.

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Page 2 of 5

• Updates on this form must be saved to the necessary tables in the database.
• This form must also be used to display the data for a person whenever the user double clicks 
on a person anywhere in the application.
• The title bar must display the person’s name as built up from the title, first name, other 
initials, surname and suffix if present.
• The ID number’s first six digits must agree with the date of birth. Digits seven through ten 
must agree with the person’s sex (< 5000 for females, ≥ 5000 for males). The ID number 
consists of exactly thirteen numeric digits.
• The title is stored as valid values (1=Mr, 2=Mrs, 3=Miss, 4=Ms, 10=Dr, 11=Prof) and sex is 
stored as valid values (1=Female, 2=Male).
• The date of birth must be presented with a dropdown calendar.
• The working hours must be in a dropdown control containing the defined schedules.
• The Roles button links to a form where the role performed by a person is defined for every 
team that the person belongs to. Roles are stored as valid values (1=Manager, 2=Secretary, 
10=Developer, 11=DBA, 12=Designer, 20=Tester).
• The Diary button links to a form where all the diary items for the person, that have not yet 
occurred, are displayed.
• Double clicking on the working hours opens a form where the days and hours for that 
schedule may be edited. This represents the working schedule for this person.
• All controls must be bound to the appropriate business objects (or collections of business 
objects) from the business logic layer. Presentation layer controls may not bypass the 
business logic layer to communicate with the data access layer.
Teams:
Search for a team as for a person.
The name of the team is displayed in the title bar of the form as shown above.
When a list of teams is presented, it should be sorted according to the team name. (Also note the 
order of persons here, sorted as described in the previous section.)
Updates to be saved to the database as necessary.
Double clicking on a person opens the detail form for that person.Practice: Software Engineering 381

------------------------------------------------------------------------------------------------------------------------------------------------------
Page 3 of 5
It must be possible to add members to a team, change their role on the team, and remove members 
from a team. Only one team member may fulfil the role of Manager.
The roles that team members may fulfil are from the valid values as specified before for a person.
Double clicking on the working hours opens a form where the days and hours for that schedule may 
be edited. This represents the working schedule for this team. These hours apply to all members of 
the team, except where an overriding schedule has been specified for a specific team member.
Activities:
Create the necessary form to create activities, which represent the diary entries scheduled for 
persons.
An Activity is specialised as a Task or a Meeting.
Details about any activity may be specified and stored in the Notes field.
A Task is scheduled with a single person (as owner) and appears only in that person’s diary.
A Meeting has an owner (the convener of the meeting) and at least one other participant. The 
meeting will appear in the diaries of all the persons involved.
A Meeting is specialised as a TeamMeeting, a PerformanceEvaluation, or an AdHocMeeting.
A TeamMeeting is scheduled with the Manager of the team as the owner of the meeting and all the 
other team members as participants.
A PerformanceEvaluation is scheduled with the Manager of the team as the owner of the meeting 
and one other team member of that same team as participant.
An AdHocMeeting is scheduled with the person convening the meeting as owner.
Any other persons (from any teams) may be invited to an ad hoc meeting as participants.
When a meeting is scheduled, the diaries of all persons involved must be checked for conflicts. The 
entire meeting must also take place within the working hours of each person invited to the meeting. 
A schedule for a person (if specified) takes precedence over any schedules specified for teams that 
the person belongs to. If no schedules apply for a person, a default schedule of 08h00 – 18h00 on 
weekdays only, will apply.
If participants are not available for the time requested for an activity, the user must be informed and 
allowed to modify the details of the meeting (by changing times, removing participants, etc.) and 
attempt to schedule again.
If all participants are available, the meeting is scheduled and will appear in all the participants’ 
diaries.
A meeting may be cancelled, in which case it is removed from all the related diaries.
Work schedules:
Work schedules are created to specify working hours.
The day of the week is stored as valid values, using the standard 0=Sunday to 6=Saturday.
Multiple periods are specified per day as necessary to allow for lunch breaks, e.g. 08h00 – 12h00 and 
13h00 – 17h00 on Monday, etc.
The form to show a schedule’s details should be displayed whenever the user double clicks on a 
schedule in, e.g., the Person form or the Team form.Practice: Software Engineering 381

------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Page 4 of 5
General instructions:
• All code must be written in C#.NET in VisualStudio and object-oriented principles must be 
adhered to at all times.
• All user interfaces must be built as Windows forms(Only windows forms are provided).
• You may assume that the application will run on a single PC with a local database. 
Concurrency issues need only be considered as applicable to this scenario.
• The solution must run as a single, integrated application where all forms are connected and 
navigable from the central starting point.
• Do not create logon or security functionality; start the application directly.
• There must be no unhandled exceptions. User-friendly messages must be used to 
communicate with the user.
• All forms (and navigation between them) must be user-friendly and intuitive.
• The user interfaces must possess correct tab orders and be navigable via the keyboard. Use 
tool tips as appropriate to enhance the user experience.
• Double clicking on any entity should display the detail form for that entity.
• The database design may not be altered. The application must function on the database as 
supplied with regard to, e.g., data types, column attributes, and referential integrity 
constraints.
Allocation of marks for practical work:
Business requirements (as specified) [30]
Person maintenance [4]
Person search [4]
Person diary [4]
Person roles [2]
Team search and maintenance [2]
Team member maintenance [3]
Management of work schedules [2]
Creation of activities of all types [3]
Conflict checking and resolution for meetings [4]
Creating and cancelling activities [2]
Presentation layer [20]
Choice of controls for data types [1]
Validation [2]
Data binding to business objects [4]
Event handling [2]
Navigation [1]
Exception handling [3]
Implementation of search functions [1]
Double click to zoom to details [2]
Naming standards [1]
Dynamic form titles [2]
Intuitive user interaction [1]Practice: Software Engineering 381


-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Page 5 of 5
Business logic layer [20]
Class definitions [2]
Inheritance hierarchies [2]
Implementation of interfaces [2]
Standard methods [2]
Encapsulation [2]
Sort order [4]
Readonly and read-write properties [1]
Naming standards [1]
Enumerations [2]
Instantiation [2]
Data access layer [15]
Database adapters [2]
Datasets and data tables [3]
Factory methods [3]
Matching of .NET data type to SQL data types [2]
NULL data values [1]
Reading of object data [1]
Updating of object data [3]
Architecture [15]
Separation of responsibilities [5]
Location of functionality within application 
layers
[4]
Reuse of components and functions [6
