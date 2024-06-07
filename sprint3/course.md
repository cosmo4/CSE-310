# CSE 310 - Module Report

Name: Luke Warner

## Part 1 - Module Planning

This section should be filled on the first Monday of the Sprint and submitted

### Section 1.1 - Module Selection

1. What Sprint is this for (1-5)? 3

2. Select the Module (with a single X) that you will do this Sprint:

|Module                   |Selected Module|
|-------------------------|---------------|
|Cloud Databases          |       X       |
|Data Analysis            |               |
|Game Framework           |               |
|GIS Mapping              |               |
|Mobile App               |               |
|Networking               |               |
|SQL Relational Databases |               |
|Web Apps                 |               |
|C++                      |               |
|Java                     |               |
|Kotlin                   |               |
|Erlang                   |               |
|TypeScript               |               |
|Rust                     |               |
|Choose Your Own Adventure|               |

3. Find the list of unique requirements for your selected module in the Module Summary in Canvas.  In some circumstances, you will need to modify the requirements based on the technology or language you selected.  For the Choose Your Own Adventure, you need to create your own requirements.  List the unique module requirements below:

#### Develop software that interacts with a cloud database. The software must have the following characteristics:

* You must create a database using a cloud service for your program to use including at least one table to store data into.

* Your software must demonstrate the ability to insert, modify, delete, and retrieve (or query) data.

#### Stretch Challenges (select one):

* Receive notifications in your software when data in the cloud changes.

* Create two or more tables that are related to each other.

* Implement user authentication.
### Section 1.2 - Planning

During the Sprint, you will spend 4 hours in class meetings, 4 hours on your team project (2 of which during class), and 10 hours on your selected module.  Make a plan for your 10 hours by answering the questions below.  You should refer back to this plan and make adjustments during the Sprint.

1. What sources have you selected to learn the technical material?
* [AWS DynamoDB course](https://aws.amazon.com/dynamodb/getting-started/)
* [AWS DynamoDB For The .NET Developer: How To Easily Get Started](https://www.youtube.com/watch?v=BbUmLRaxZG8)
* [AWS DynamoDB Tutorial For Beginners](https://www.youtube.com/watch?v=2k2GINpO308)

2. What is your plan to practice the new material?  In other words, what is the order in which you plan to learn the material before working on your demonstration software?

I want to spend a few hours on the tutorial developed by Amazon. I think they would know best how their services work. Then after I have some basics, I will move onto the youtube tutorials. Depending on my level of confidence, I might use the things taught in the tutorials and modify them to fit the program I am making.

3. What demonstration software do you plan on submitting at the end of the Sprint (note that this can and may change)?

I want to have a basic frontend built out that a user can login/signup and manage information dealing with their Lego Star Wars collection, i.e. sets, characters, etc.

4. Identify the days, times, and locations that you will work on the module.

Because my goal this sprint is to do something every week day for my project, I will work on my module right after class at home on MWF and in between my classes on TTH.

5. Identify both a technical risk and a behavioral risk that you antcipate may occur during this Sprint.  What is your mitgigation plan?

I've never combined .NET with a cloud database. I am interested to try it, but I might need to switch to something more familiar to me like Node.js and Express. I will determine if I need to make this switch by the end of week 6.


## Part 2 - Time Log

This section should be filled out during the Sprint. 

Record all CSE 310 work that you do on your individual module or the team project.  Include time learning, practicing, developing, testing, and documenting.  Don't include time spent in the 4 class meetings (Planning, Stand-Up, Team Review, and Individual Review).  You will need to sum of these hours at the end of the Sprint. Note that the hours you report will affect your grades.

Note that `IM` stands for Individual Module and `TP` stands for Team Project.  

|Date      |Start Time|IM or TP|Description                                 |Hours:Minutes|
|----------|----------|--------|--------------------------------------------|-------------|
|   5/30   |   4:00   |   TP   | Implemented login/signup to production env |    3:30     |
|   5/31   |   11:30  |   IM   |Started learning DynamoDB changed to MongoDb|    3:25     |
|   6/3    |   2:15   |   IM   |Followed along with .NET tutorial fixed bugs|    4:10     |
|   6/4    |   8:40   |   IM   |Followed tutorial for beginners started proj|    2:40     |
|   6/5    |   5:25   |   IM   | Added get,post,put,delete requests         |    3:15     |
|          |          |        |                                            |             |

_Note: Add more rows as needed._


## Part 3 - Module Results

This section should be filled out at the end of the Sprint and submitted.

1. Put your GitHub link for your demonstration software here: 

2. Put your YouTube link for your code walkthrough and demo video here:

3. Complete the following checklist by either indicating "Yes" or "No". If you indicate "No" then provide an explanation of why beneath the table.

|Question                                                    |Response|
|------------------------------------------------------------|--------|
|Are the links above public and working?                     |        |
|Did you complete all the unique requirements for the module?|        |
|Did you write at least 100 lines of code?                   |        |
|Did you fully complete the readme.md file?                  |        |
|Did you put the readme.md file in GitHub in the top folder? |        |

4. If you completed a Stretch Challenge (as shown in the Module Description document in Canvas) then describe what you did.  If you did the Choose Your Own Adventure module, then you get to decide what qualifies as a Stretch Challenge.

5. Did you change your selected module during the middle of the Sprint?  If yes, then describe what you changed it to, when you changed it, and why you changed it.

6. Using the log above, fill in the total hours and minutes you spent on the individual module:

|Activity         |Total Hours:Minutes|
|-----------------|-------------------|
|Individual Module|       13:25       |

7. What strategies (behavioral and technical) worked well during this Sprint?  What did not work well?  List some possible ways that you can improve next Sprint.

I think that doing a little bit everyday helped to guide me towards the final product I have. Being set on one software tool cost me a few hours. I was having so many problems with AWS DynamoDB that I decided to change cloud services entirely. I think I should've seriously considered the Guidance section recommending python and google firestore.

