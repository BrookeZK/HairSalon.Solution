# _Solution Center: Cutterz Barber Shop_

#### _Program which allows employees at Cutterz Barber Shop to manage employees and their clients, 05/10/2019_

#### By _**Brooke Kullberg**_

## Description

_This is buisness software to help organize, manage and run the day to day details of "Cutterz Barber Shop". This program allows managers to add new employees to their system, including details about their work experience, and work availability. This page also lists all specialties associated with the stylist, providing the ability to add multiple specialties to each stylist. After a stylist to saved into the system, the user can add new clients; clients must be associated with a specific Stylist. Managing client information includes the options to view, update and delete, and keeps track of appointment details, such as time and date, and the requested service. Finally, this program also manages information about offered services via specialties and their prices. On the Specialties homepage, the user can view all specialties in the database, add and delete specialties, and select one to view detailed information. The user can also view all stylists associated with each specialty, and add more stylists to a specialty._

## Setup/Installation Requirements: Database

_To download and import the database:_

* _Start MAMP and click Open WebStart page in the MAMP window._
* _In the website you're taken to, select phpMyAdmin from the Tools dropdown._
* _Select the Import tab._
* _Note that it's important to make sure you're not importing to a database that already exists, so make sure that a database with the same name as the one you're importing isn't already present._
* _Select your database file, and click Go._

_To make your own database in MySql shell:_

* _CREATE DATABASE brooke_kullberg;_
* _USE brooke_kullberg;_
* _CREATE TABLE stylists (id serial PRIMARY KEY, name VARCHAR(255), years_of_experience INT, work_days VARCHAR(255));_
* _CREATE TABLE clients (id serial PRIMARY KEY, name VARCHAR(255), services_resquested TEXT, appointment_time DATE, stylist_id INT);_
* _CREATE TABLE specialties (id serial PRIMARY KEY, name VARCHAR(255), price INT);_
* _CREATE TABLE service_requests (id serial PRIMARY KEY, specialty_id INT, stylist_id INT, client_id INT);_

## Setup/Installation Requirements: Program

* _Open via GitHub repository by going to <https://github.com/BrookeZK/HairSalon.Solution.git>._
* _In your command line (Terminal or another program), navigate to your desktop._
* _In your command line, type "git clone https://github.com/BrookeZK/HairSalon.Solution.git" to clone the repository to your desktop._
* _In your command line, navigate into the new folder "HairSalon.Solution", then into the subfolder "HairSalon"._
* _Once inside "HairSalon," type "dotnet run", and your terminal will inform you that the program is running on <http://localhost:5000>._
* _Finally, put the url <http://localhost:5000> into your web browser and the program will open.._

## Specs

| Behavior | Input / Output |
| ------------- |:-------------:|
| 1a. Upon launching the program, the user is prompted to login | Enter username and password, click submit |
| 1b. Upon logging in, user has option to *View Stylists*, *Add a new Stylist*, *View Specialties* or *Add new specialty* | After login authentication, user will be on the homepage |
| 2a. Upon clicking on *Add a new stylist*, user is presented with form, input fields, and an *Add* button | Click *Add a new stylist* and it will be added to database, and the page redirected to a list of all stylists |
| 2b. Upon clicking on  *View Stylists*, user is presented with list of the stylists in the database| redirection to a new page with list of stylists |
| 2c. Upon clicking on *Add a new specialty*, user is presented with form, input fields, and an *Add* button | Click *Add a new specialty* and it will be added to database, and the page redirected to a list of all specialties |
| 2d. Upon clicking on  *View Specialties*, user is presented with list of the specialties in the database| redirection to a new page with list of specialties |
| 3a. User can click stylist name | they will be redirect to their info page, and the ability to view specialties associated with stylist, search all specialties and add them to the stylist |
| 3b. User can click specialty name | they will be redirect to its info page, and the ability to view stylists associated with that specialty, search all stylists and add them to a specialty |
| 4a. User has option to *Add a new client*, *Return to Stylist List* or go *Back to Homepage* | Clicking these buttons will navigate you to the corresponding page |
| 4b. User has option to *Add a new specialty, *Return to Specialty List* or go *Back to Homepage* | Clicking these buttons will navigate you to the corresponding page |
| 5. After step 4a, upon clicking on *Add a new client*, user is presented with input field and an *Add* button | Click *Add a new client*, and you will be redirected to the stylist info page, where the client will be displayed in a list|
| 6. Upon clicking on a client's name, user is directed to a detailed description of that client | Click on a client button and you will be redirected to the corresponding info page  |
| 7. After setp 6, user has the option to navigate to the stylist home page, the lists of all stylists or the main homepage | clicking a button will cause the program to navigate to the corresponding web page |

## Known Bugs

_For the homepage after the login in: the welcome image fails to load._
_There are two tests in both the StylistTests and SpecialtyTests that do not work - they are commented out._

## Support and contact details

_Please contact me at brookekullberg@gmail.com if you run into any issues or have questions, ideas or feedback._

## Technologies Used

_C#_

### License

*This software is licensed under the GPL license.*

Copyright (c) 2019 **_Brooke Kullberg_**
