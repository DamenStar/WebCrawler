# WebCrawler

I built the WebCrawler application using .NET Core 3.1 with C#. It uses built in framework features suxch as tasks, configuration with json files, and HttpClient.

It is a .NET Core console applicatioin. I used the HtmlAgilityPack component which is an HTML parser written in C# to read/write DOM as well as plain XPATH or XSLT. This component
comes from nuget which is the package manager for .NET and .NET Core.

The application also can run in Docker. The Dockerfile is included. 

There is appsettings.json file that contains:
{
  "url": "http://wiprodigital.com"
}

This defines the site that is to be crawled. One can pass in argument that defines either the site above or another site.

It retrieves the elements of a site and using XPATH to retrieve the links and send them to standard output.

Additional Features:

If I was going to enhance this application, I would have turned this into a microservice or service using ASP.NET Core. This would allow to run a a lightweight process using the
lighweight web server, Kestrel. This can be exposed through an API gateway such as nginx. I would have stored the data retrieved in a database like Postgres or SQLServer. Going beyond
these features would require the following considerations:

I would have to have to deal with storage and extensibility. Since the crawler could search sites with a lot of links, this would generate a lot of data. This could require that the 
data be compressed. This would also require the crawler be using a framework in order to make extensible to adjust to changing requirments. The crawler would need to deal with other
languages other than English. The crawler would need to considerate of the sites crawled so as to not effect their performance and bandwidth.

Github: https://github.com/DamenStar/WebCrawler

Mac Usage:

Note: I have no experience with the Mac and have never used so my knowledge is based on documentation. It is supposed to work the same based on articles:

https://www.davidhayden.me/blog/visual-studio-code-for-developing-net-core-c-apps-on-macos
https://jakeydocs.readthedocs.io/en/latest/tutorials/your-first-mac-aspnet.html
I also checked with a friend who builds .NET Core apps on the Mac.

Go the page: https://dotnet.microsoft.com/download/dotnet-core/3.1 (SDK 3.1.201)

Download the version for the Mac

Open a command prompt and change directory to the WebCrawler directory.

At the top level of the WebCrawler directory, run the commands:

dotnet restore
dotnet build
dotnet run which will product the following output:

Site is https://wiprodigital.com

https://wiprodigital.com
https://wiprodigital.com/who-we-are
https://wiprodigital.com/who-we-are
https://wiprodigital.com/who-we-are/#wdteam-vid
https://wiprodigital.com/who-we-are#wdteam_meetus
https://wiprodigital.com/who-we-are#wdteam_leaders
https://wiprodigital.com/what-we-do
https://wiprodigital.com/what-we-do#work-three-circles-row
https://wiprodigital.com/what-we-do#wdwork_cases
https://wiprodigital.com/what-we-do#wdwork_partners
https://wiprodigital.com/what-we-think
https://wiprodigital.com/?s=&post_type[]=post
https://wiprodigital.com/?s=&post_type[]=cases
https://wiprodigital.com/?s=&post_type[]=events
https://wiprodigital.com/?s=&post_type[]=news
https://wiprodigital.com/join-our-team
https://wiprodigital.com/join-our-team
https://wiprodigital.com/join-our-team#wdwork-vid
https://wiprodigital.com/join-our-team#wdcareers_team
https://wiprodigital.com/join-our-team#wdcareers_jobs
https://wiprodigital.com/get-in-touch
https://wiprodigital.com/get-in-touch#wddi-locations
https://wiprodigital.com/get-in-touch#wddi-contact
https://wiprodigital.com/news/wipro-digital-acquires-rational-interaction-enhancing-customer-experience-offerings-and-boosting-digital-marketing-capabilities/
https://wiprodigital.com/2019/09/09/lets-get-real-how-do-you-become-digital/
https://wiprodigital.com/news/digital-pods-bring-clients-a-closer-relationship-with-solutions/
https://wiprodigital.com/cases/empowering-a1-telekom-to-reinvent-itself-with-digital-transformation/
https://wiprodigital.com/2019/08/26/how-connected-cars-and-digital-prescriptive-maintenance-provide-proactive-customer-service/
https://wiprodigital.com/2020/02/21/delivering-the-experience-of-a-customer-lifetime/
https://wiprodigital.com/cases/enabling-transformation-in-healthcare-and-life-sciences/
https://wiprodigital.com/services/no-shore-model/
https://wiprodigital.com/cases/transforming-payment-authentications-into-cloud-based-microservices-on-pivotal-cloud-foundry/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/who-we-are/
https://wiprodigital.com
https://www.facebook.com/WiproDigital/
https://twitter.com/wiprodigital
https://www.linkedin.com/company/wipro-digital
https://wiprodigital.com/who-we-are/
https://wiprodigital.com/who-we-are/#wdteam_meetus
https://wiprodigital.com/who-we-are/#wdteam_leaders
https://wiprodigital.com/what-we-do/#work-three-circles-row
https://wiprodigital.com/what-we-do/#wdwork_cases
https://wiprodigital.com/what-we-do/#wdwork_partners
https://wiprodigital.com/?s=&post_type[]=post
https://wiprodigital.com/?s=&post_type[]=news
https://wiprodigital.com/?s=&post_type[]=events
https://wiprodigital.com/join-our-team/
https://wiprodigital.com/join-our-team/#wdcareers_team
https://wiprodigital.com/join-our-team/#wdcareers_jobs
https://wiprodigital.com/privacy-policy/
https://wiprodigital.com/privacy-policy/

dotnecore run http://wiprodigital.com will produce the following output:

Site is http://wiprodigital.com

https://wiprodigital.com
https://wiprodigital.com/who-we-are
https://wiprodigital.com/who-we-are
https://wiprodigital.com/who-we-are/#wdteam-vid
https://wiprodigital.com/who-we-are#wdteam_meetus
https://wiprodigital.com/who-we-are#wdteam_leaders
https://wiprodigital.com/what-we-do
https://wiprodigital.com/what-we-do#work-three-circles-row
https://wiprodigital.com/what-we-do#wdwork_cases
https://wiprodigital.com/what-we-do#wdwork_partners
https://wiprodigital.com/what-we-think
https://wiprodigital.com/?s=&post_type[]=post
https://wiprodigital.com/?s=&post_type[]=cases
https://wiprodigital.com/?s=&post_type[]=events
https://wiprodigital.com/?s=&post_type[]=news
https://wiprodigital.com/join-our-team
https://wiprodigital.com/join-our-team
https://wiprodigital.com/join-our-team#wdwork-vid
https://wiprodigital.com/join-our-team#wdcareers_team
https://wiprodigital.com/join-our-team#wdcareers_jobs
https://wiprodigital.com/get-in-touch
https://wiprodigital.com/get-in-touch#wddi-locations
https://wiprodigital.com/get-in-touch#wddi-contact
https://wiprodigital.com/news/wipro-digital-acquires-rational-interaction-enhancing-customer-experience-offerings-and-boosting-digital-marketing-capabilities/
https://wiprodigital.com/2019/09/09/lets-get-real-how-do-you-become-digital/
https://wiprodigital.com/news/digital-pods-bring-clients-a-closer-relationship-with-solutions/
https://wiprodigital.com/cases/empowering-a1-telekom-to-reinvent-itself-with-digital-transformation/
https://wiprodigital.com/2019/08/26/how-connected-cars-and-digital-prescriptive-maintenance-provide-proactive-customer-service/
https://wiprodigital.com/2020/02/21/delivering-the-experience-of-a-customer-lifetime/
https://wiprodigital.com/cases/enabling-transformation-in-healthcare-and-life-sciences/
https://wiprodigital.com/services/no-shore-model/
https://wiprodigital.com/cases/transforming-payment-authentications-into-cloud-based-microservices-on-pivotal-cloud-foundry/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/who-we-are/
https://wiprodigital.com
https://www.facebook.com/WiproDigital/
https://twitter.com/wiprodigital
https://www.linkedin.com/company/wipro-digital
https://wiprodigital.com/who-we-are/
https://wiprodigital.com/who-we-are/#wdteam_meetus
https://wiprodigital.com/who-we-are/#wdteam_leaders
https://wiprodigital.com/what-we-do/#work-three-circles-row
https://wiprodigital.com/what-we-do/#wdwork_cases
https://wiprodigital.com/what-we-do/#wdwork_partners
https://wiprodigital.com/?s=&post_type[]=post
https://wiprodigital.com/?s=&post_type[]=news
https://wiprodigital.com/?s=&post_type[]=events
https://wiprodigital.com/join-our-team/
https://wiprodigital.com/join-our-team/#wdcareers_team
https://wiprodigital.com/join-our-team/#wdcareers_jobs
https://wiprodigital.com/privacy-policy/
https://wiprodigital.com/privacy-policy/

Mac - Docker Usage:

Docker Installation:

https://docs.docker.com/docker-for-mac/install/

Before you can add the .NET Core app to the Docker image, you must do the following:

Open a command prompt and change directory to the WebCrawler directory.

At the top level of the WebCrawler directory, run the commands:

dotnet publish -c Release

Create Docker Image:

docker build -t webcrawler -f Dockerfile .

Check the Docker images and you should see a webcrawler image.

Run the Docker image:

docker run webcrawler

This will produce this output:

Site is https://wiprodigital.com

https://wiprodigital.com
https://wiprodigital.com/who-we-are
https://wiprodigital.com/who-we-are
https://wiprodigital.com/who-we-are/#wdteam-vid
https://wiprodigital.com/who-we-are#wdteam_meetus
https://wiprodigital.com/who-we-are#wdteam_leaders
https://wiprodigital.com/what-we-do
https://wiprodigital.com/what-we-do#work-three-circles-row
https://wiprodigital.com/what-we-do#wdwork_cases
https://wiprodigital.com/what-we-do#wdwork_partners
https://wiprodigital.com/what-we-think
https://wiprodigital.com/?s=&post_type[]=post
https://wiprodigital.com/?s=&post_type[]=cases
https://wiprodigital.com/?s=&post_type[]=events
https://wiprodigital.com/?s=&post_type[]=news
https://wiprodigital.com/join-our-team
https://wiprodigital.com/join-our-team
https://wiprodigital.com/join-our-team#wdwork-vid
https://wiprodigital.com/join-our-team#wdcareers_team
https://wiprodigital.com/join-our-team#wdcareers_jobs
https://wiprodigital.com/get-in-touch
https://wiprodigital.com/get-in-touch#wddi-locations
https://wiprodigital.com/get-in-touch#wddi-contact
https://wiprodigital.com/news/wipro-digital-acquires-rational-interaction-enhancing-customer-experience-offerings-and-boosting-digital-marketing-capabilities/
https://wiprodigital.com/2019/09/09/lets-get-real-how-do-you-become-digital/
https://wiprodigital.com/news/digital-pods-bring-clients-a-closer-relationship-with-solutions/
https://wiprodigital.com/cases/empowering-a1-telekom-to-reinvent-itself-with-digital-transformation/
https://wiprodigital.com/2019/08/26/how-connected-cars-and-digital-prescriptive-maintenance-provide-proactive-customer-service/
https://wiprodigital.com/2020/02/21/delivering-the-experience-of-a-customer-lifetime/
https://wiprodigital.com/cases/enabling-transformation-in-healthcare-and-life-sciences/
https://wiprodigital.com/services/no-shore-model/
https://wiprodigital.com/cases/transforming-payment-authentications-into-cloud-based-microservices-on-pivotal-cloud-foundry/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/who-we-are/
https://wiprodigital.com
https://www.facebook.com/WiproDigital/
https://twitter.com/wiprodigital
https://www.linkedin.com/company/wipro-digital
https://wiprodigital.com/who-we-are/
https://wiprodigital.com/who-we-are/#wdteam_meetus
https://wiprodigital.com/who-we-are/#wdteam_leaders
https://wiprodigital.com/what-we-do/#work-three-circles-row
https://wiprodigital.com/what-we-do/#wdwork_cases
https://wiprodigital.com/what-we-do/#wdwork_partners
https://wiprodigital.com/?s=&post_type[]=post
https://wiprodigital.com/?s=&post_type[]=news
https://wiprodigital.com/?s=&post_type[]=events
https://wiprodigital.com/join-our-team/
https://wiprodigital.com/join-our-team/#wdcareers_team
https://wiprodigital.com/join-our-team/#wdcareers_jobs
https://wiprodigital.com/privacy-policy/
https://wiprodigital.com/privacy-policy/

docker run webcrawler  https://wiprodigital.com

Site is https://wiprodigital.com

https://wiprodigital.com
https://wiprodigital.com/who-we-are
https://wiprodigital.com/who-we-are
https://wiprodigital.com/who-we-are/#wdteam-vid
https://wiprodigital.com/who-we-are#wdteam_meetus
https://wiprodigital.com/who-we-are#wdteam_leaders
https://wiprodigital.com/what-we-do
https://wiprodigital.com/what-we-do#work-three-circles-row
https://wiprodigital.com/what-we-do#wdwork_cases
https://wiprodigital.com/what-we-do#wdwork_partners
https://wiprodigital.com/what-we-think
https://wiprodigital.com/?s=&post_type[]=post
https://wiprodigital.com/?s=&post_type[]=cases
https://wiprodigital.com/?s=&post_type[]=events
https://wiprodigital.com/?s=&post_type[]=news
https://wiprodigital.com/join-our-team
https://wiprodigital.com/join-our-team
https://wiprodigital.com/join-our-team#wdwork-vid
https://wiprodigital.com/join-our-team#wdcareers_team
https://wiprodigital.com/join-our-team#wdcareers_jobs
https://wiprodigital.com/get-in-touch
https://wiprodigital.com/get-in-touch#wddi-locations
https://wiprodigital.com/get-in-touch#wddi-contact
https://wiprodigital.com/news/wipro-digital-acquires-rational-interaction-enhancing-customer-experience-offerings-and-boosting-digital-marketing-capabilities/
https://wiprodigital.com/2019/09/09/lets-get-real-how-do-you-become-digital/
https://wiprodigital.com/news/digital-pods-bring-clients-a-closer-relationship-with-solutions/
https://wiprodigital.com/cases/empowering-a1-telekom-to-reinvent-itself-with-digital-transformation/
https://wiprodigital.com/2019/08/26/how-connected-cars-and-digital-prescriptive-maintenance-provide-proactive-customer-service/
https://wiprodigital.com/2020/02/21/delivering-the-experience-of-a-customer-lifetime/
https://wiprodigital.com/cases/enabling-transformation-in-healthcare-and-life-sciences/
https://wiprodigital.com/services/no-shore-model/
https://wiprodigital.com/cases/transforming-payment-authentications-into-cloud-based-microservices-on-pivotal-cloud-foundry/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/who-we-are/
https://wiprodigital.com
https://www.facebook.com/WiproDigital/
https://twitter.com/wiprodigital
https://www.linkedin.com/company/wipro-digital
https://wiprodigital.com/who-we-are/
https://wiprodigital.com/who-we-are/#wdteam_meetus
https://wiprodigital.com/who-we-are/#wdteam_leaders
https://wiprodigital.com/what-we-do/#work-three-circles-row
https://wiprodigital.com/what-we-do/#wdwork_cases
https://wiprodigital.com/what-we-do/#wdwork_partners
https://wiprodigital.com/?s=&post_type[]=post
https://wiprodigital.com/?s=&post_type[]=news
https://wiprodigital.com/?s=&post_type[]=events
https://wiprodigital.com/join-our-team/
https://wiprodigital.com/join-our-team/#wdcareers_team
https://wiprodigital.com/join-our-team/#wdcareers_jobs
https://wiprodigital.com/privacy-policy/
https://wiprodigital.com/privacy-policy/

Windows Usage:

Go the page: https://dotnet.microsoft.com/download/dotnet-core/3.1 (SDK 3.1.201)

Download the version for Windows

Open a command prompt and change directory to the WebCrawler directory.

At the top level of the directory, run the commands:

dotnet restore
dotnet build
dotnet run which will product the following output:

Site is https://wiprodigital.com

https://wiprodigital.com
https://wiprodigital.com/who-we-are
https://wiprodigital.com/who-we-are
https://wiprodigital.com/who-we-are/#wdteam-vid
https://wiprodigital.com/who-we-are#wdteam_meetus
https://wiprodigital.com/who-we-are#wdteam_leaders
https://wiprodigital.com/what-we-do
https://wiprodigital.com/what-we-do#work-three-circles-row
https://wiprodigital.com/what-we-do#wdwork_cases
https://wiprodigital.com/what-we-do#wdwork_partners
https://wiprodigital.com/what-we-think
https://wiprodigital.com/?s=&post_type[]=post
https://wiprodigital.com/?s=&post_type[]=cases
https://wiprodigital.com/?s=&post_type[]=events
https://wiprodigital.com/?s=&post_type[]=news
https://wiprodigital.com/join-our-team
https://wiprodigital.com/join-our-team
https://wiprodigital.com/join-our-team#wdwork-vid
https://wiprodigital.com/join-our-team#wdcareers_team
https://wiprodigital.com/join-our-team#wdcareers_jobs
https://wiprodigital.com/get-in-touch
https://wiprodigital.com/get-in-touch#wddi-locations
https://wiprodigital.com/get-in-touch#wddi-contact
https://wiprodigital.com/news/wipro-digital-acquires-rational-interaction-enhancing-customer-experience-offerings-and-boosting-digital-marketing-capabilities/
https://wiprodigital.com/2019/09/09/lets-get-real-how-do-you-become-digital/
https://wiprodigital.com/news/digital-pods-bring-clients-a-closer-relationship-with-solutions/
https://wiprodigital.com/cases/empowering-a1-telekom-to-reinvent-itself-with-digital-transformation/
https://wiprodigital.com/2019/08/26/how-connected-cars-and-digital-prescriptive-maintenance-provide-proactive-customer-service/
https://wiprodigital.com/2020/02/21/delivering-the-experience-of-a-customer-lifetime/
https://wiprodigital.com/cases/enabling-transformation-in-healthcare-and-life-sciences/
https://wiprodigital.com/services/no-shore-model/
https://wiprodigital.com/cases/transforming-payment-authentications-into-cloud-based-microservices-on-pivotal-cloud-foundry/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/who-we-are/
https://wiprodigital.com
https://www.facebook.com/WiproDigital/
https://twitter.com/wiprodigital
https://www.linkedin.com/company/wipro-digital
https://wiprodigital.com/who-we-are/
https://wiprodigital.com/who-we-are/#wdteam_meetus
https://wiprodigital.com/who-we-are/#wdteam_leaders
https://wiprodigital.com/what-we-do/#work-three-circles-row
https://wiprodigital.com/what-we-do/#wdwork_cases
https://wiprodigital.com/what-we-do/#wdwork_partners
https://wiprodigital.com/?s=&post_type[]=post
https://wiprodigital.com/?s=&post_type[]=news
https://wiprodigital.com/?s=&post_type[]=events
https://wiprodigital.com/join-our-team/
https://wiprodigital.com/join-our-team/#wdcareers_team
https://wiprodigital.com/join-our-team/#wdcareers_jobs
https://wiprodigital.com/privacy-policy/
https://wiprodigital.com/privacy-policy/

dotnecore run http://wiprodigital.com will produce the following output:

Site is http://wiprodigital.com

https://wiprodigital.com
https://wiprodigital.com/who-we-are
https://wiprodigital.com/who-we-are
https://wiprodigital.com/who-we-are/#wdteam-vid
https://wiprodigital.com/who-we-are#wdteam_meetus
https://wiprodigital.com/who-we-are#wdteam_leaders
https://wiprodigital.com/what-we-do
https://wiprodigital.com/what-we-do#work-three-circles-row
https://wiprodigital.com/what-we-do#wdwork_cases
https://wiprodigital.com/what-we-do#wdwork_partners
https://wiprodigital.com/what-we-think
https://wiprodigital.com/?s=&post_type[]=post
https://wiprodigital.com/?s=&post_type[]=cases
https://wiprodigital.com/?s=&post_type[]=events
https://wiprodigital.com/?s=&post_type[]=news
https://wiprodigital.com/join-our-team
https://wiprodigital.com/join-our-team
https://wiprodigital.com/join-our-team#wdwork-vid
https://wiprodigital.com/join-our-team#wdcareers_team
https://wiprodigital.com/join-our-team#wdcareers_jobs
https://wiprodigital.com/get-in-touch
https://wiprodigital.com/get-in-touch#wddi-locations
https://wiprodigital.com/get-in-touch#wddi-contact
https://wiprodigital.com/news/wipro-digital-acquires-rational-interaction-enhancing-customer-experience-offerings-and-boosting-digital-marketing-capabilities/
https://wiprodigital.com/2019/09/09/lets-get-real-how-do-you-become-digital/
https://wiprodigital.com/news/digital-pods-bring-clients-a-closer-relationship-with-solutions/
https://wiprodigital.com/cases/empowering-a1-telekom-to-reinvent-itself-with-digital-transformation/
https://wiprodigital.com/2019/08/26/how-connected-cars-and-digital-prescriptive-maintenance-provide-proactive-customer-service/
https://wiprodigital.com/2020/02/21/delivering-the-experience-of-a-customer-lifetime/
https://wiprodigital.com/cases/enabling-transformation-in-healthcare-and-life-sciences/
https://wiprodigital.com/services/no-shore-model/
https://wiprodigital.com/cases/transforming-payment-authentications-into-cloud-based-microservices-on-pivotal-cloud-foundry/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/who-we-are/
https://wiprodigital.com
https://www.facebook.com/WiproDigital/
https://twitter.com/wiprodigital
https://www.linkedin.com/company/wipro-digital
https://wiprodigital.com/who-we-are/
https://wiprodigital.com/who-we-are/#wdteam_meetus
https://wiprodigital.com/who-we-are/#wdteam_leaders
https://wiprodigital.com/what-we-do/#work-three-circles-row
https://wiprodigital.com/what-we-do/#wdwork_cases
https://wiprodigital.com/what-we-do/#wdwork_partners
https://wiprodigital.com/?s=&post_type[]=post
https://wiprodigital.com/?s=&post_type[]=news
https://wiprodigital.com/?s=&post_type[]=events
https://wiprodigital.com/join-our-team/
https://wiprodigital.com/join-our-team/#wdcareers_team
https://wiprodigital.com/join-our-team/#wdcareers_jobs
https://wiprodigital.com/privacy-policy/
https://wiprodigital.com/privacy-policy/

Windows - Docker Usage:

Docker Installation:

https://docs.docker.com/docker-for-windows/install/

This requires that Windows 10 be either Professional or Enterprise.

Before you can add the .NET Core app to the Docker image, you must do the following:

Open a command prompt and change directory to the WebCrawler directory.

At the top level of the WebCrawler directory, run the commands:

dotnet publish -c Release

Create Docker Image:

docker build -t webcrawler -f Dockerfile .

Check the Docker images and you should see a webcrawler image.

Run the Docker image:

docker run webcrawler

This will produce this output:

Site is https://wiprodigital.com

https://wiprodigital.com
https://wiprodigital.com/who-we-are
https://wiprodigital.com/who-we-are
https://wiprodigital.com/who-we-are/#wdteam-vid
https://wiprodigital.com/who-we-are#wdteam_meetus
https://wiprodigital.com/who-we-are#wdteam_leaders
https://wiprodigital.com/what-we-do
https://wiprodigital.com/what-we-do#work-three-circles-row
https://wiprodigital.com/what-we-do#wdwork_cases
https://wiprodigital.com/what-we-do#wdwork_partners
https://wiprodigital.com/what-we-think
https://wiprodigital.com/?s=&post_type[]=post
https://wiprodigital.com/?s=&post_type[]=cases
https://wiprodigital.com/?s=&post_type[]=events
https://wiprodigital.com/?s=&post_type[]=news
https://wiprodigital.com/join-our-team
https://wiprodigital.com/join-our-team
https://wiprodigital.com/join-our-team#wdwork-vid
https://wiprodigital.com/join-our-team#wdcareers_team
https://wiprodigital.com/join-our-team#wdcareers_jobs
https://wiprodigital.com/get-in-touch
https://wiprodigital.com/get-in-touch#wddi-locations
https://wiprodigital.com/get-in-touch#wddi-contact
https://wiprodigital.com/news/wipro-digital-acquires-rational-interaction-enhancing-customer-experience-offerings-and-boosting-digital-marketing-capabilities/
https://wiprodigital.com/2019/09/09/lets-get-real-how-do-you-become-digital/
https://wiprodigital.com/news/digital-pods-bring-clients-a-closer-relationship-with-solutions/
https://wiprodigital.com/cases/empowering-a1-telekom-to-reinvent-itself-with-digital-transformation/
https://wiprodigital.com/2019/08/26/how-connected-cars-and-digital-prescriptive-maintenance-provide-proactive-customer-service/
https://wiprodigital.com/2020/02/21/delivering-the-experience-of-a-customer-lifetime/
https://wiprodigital.com/cases/enabling-transformation-in-healthcare-and-life-sciences/
https://wiprodigital.com/services/no-shore-model/
https://wiprodigital.com/cases/transforming-payment-authentications-into-cloud-based-microservices-on-pivotal-cloud-foundry/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/who-we-are/
https://wiprodigital.com
https://www.facebook.com/WiproDigital/
https://twitter.com/wiprodigital
https://www.linkedin.com/company/wipro-digital
https://wiprodigital.com/who-we-are/
https://wiprodigital.com/who-we-are/#wdteam_meetus
https://wiprodigital.com/who-we-are/#wdteam_leaders
https://wiprodigital.com/what-we-do/#work-three-circles-row
https://wiprodigital.com/what-we-do/#wdwork_cases
https://wiprodigital.com/what-we-do/#wdwork_partners
https://wiprodigital.com/?s=&post_type[]=post
https://wiprodigital.com/?s=&post_type[]=news
https://wiprodigital.com/?s=&post_type[]=events
https://wiprodigital.com/join-our-team/
https://wiprodigital.com/join-our-team/#wdcareers_team
https://wiprodigital.com/join-our-team/#wdcareers_jobs
https://wiprodigital.com/privacy-policy/
https://wiprodigital.com/privacy-policy/

docker run webcrawler  https://wiprodigital.com

Site is https://wiprodigital.com

https://wiprodigital.com
https://wiprodigital.com/who-we-are
https://wiprodigital.com/who-we-are
https://wiprodigital.com/who-we-are/#wdteam-vid
https://wiprodigital.com/who-we-are#wdteam_meetus
https://wiprodigital.com/who-we-are#wdteam_leaders
https://wiprodigital.com/what-we-do
https://wiprodigital.com/what-we-do#work-three-circles-row
https://wiprodigital.com/what-we-do#wdwork_cases
https://wiprodigital.com/what-we-do#wdwork_partners
https://wiprodigital.com/what-we-think
https://wiprodigital.com/?s=&post_type[]=post
https://wiprodigital.com/?s=&post_type[]=cases
https://wiprodigital.com/?s=&post_type[]=events
https://wiprodigital.com/?s=&post_type[]=news
https://wiprodigital.com/join-our-team
https://wiprodigital.com/join-our-team
https://wiprodigital.com/join-our-team#wdwork-vid
https://wiprodigital.com/join-our-team#wdcareers_team
https://wiprodigital.com/join-our-team#wdcareers_jobs
https://wiprodigital.com/get-in-touch
https://wiprodigital.com/get-in-touch#wddi-locations
https://wiprodigital.com/get-in-touch#wddi-contact
https://wiprodigital.com/news/wipro-digital-acquires-rational-interaction-enhancing-customer-experience-offerings-and-boosting-digital-marketing-capabilities/
https://wiprodigital.com/2019/09/09/lets-get-real-how-do-you-become-digital/
https://wiprodigital.com/news/digital-pods-bring-clients-a-closer-relationship-with-solutions/
https://wiprodigital.com/cases/empowering-a1-telekom-to-reinvent-itself-with-digital-transformation/
https://wiprodigital.com/2019/08/26/how-connected-cars-and-digital-prescriptive-maintenance-provide-proactive-customer-service/
https://wiprodigital.com/2020/02/21/delivering-the-experience-of-a-customer-lifetime/
https://wiprodigital.com/cases/enabling-transformation-in-healthcare-and-life-sciences/
https://wiprodigital.com/services/no-shore-model/
https://wiprodigital.com/cases/transforming-payment-authentications-into-cloud-based-microservices-on-pivotal-cloud-foundry/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/designit-approach/
https://wiprodigital.com/who-we-are/
https://wiprodigital.com
https://www.facebook.com/WiproDigital/
https://twitter.com/wiprodigital
https://www.linkedin.com/company/wipro-digital
https://wiprodigital.com/who-we-are/
https://wiprodigital.com/who-we-are/#wdteam_meetus
https://wiprodigital.com/who-we-are/#wdteam_leaders
https://wiprodigital.com/what-we-do/#work-three-circles-row
https://wiprodigital.com/what-we-do/#wdwork_cases
https://wiprodigital.com/what-we-do/#wdwork_partners
https://wiprodigital.com/?s=&post_type[]=post
https://wiprodigital.com/?s=&post_type[]=news
https://wiprodigital.com/?s=&post_type[]=events
https://wiprodigital.com/join-our-team/
https://wiprodigital.com/join-our-team/#wdcareers_team
https://wiprodigital.com/join-our-team/#wdcareers_jobs
https://wiprodigital.com/privacy-policy/
https://wiprodigital.com/privacy-policy/