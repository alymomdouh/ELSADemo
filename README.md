# ELSADemo
##  Usefull Links 

## [1-Build and Run ASP.NET Core Apps in Containers](https://www.ezzylearning.net/tutorial/build-and-run-asp-net-core-apps-in-containers)
## [2-Complete Guide to Docker and ASP.NET Core](https://www.ezzylearning.net/tutorial/complete-guide-to-docker-and-asp-net-core)
## [3-Built-In Container Support for .NET 7 – Dockerize .NET Applications without Dockerfile!](https://codewithmukesh.com/blog/built-in-container-support-for-dotnet-7/)
## [Dockerize ASP.NET Core API and SQL Server](https://www.ezzylearning.net/tutorial/dockerize-asp-net-core-api-and-sql-server)

## Use This WebSite To Test Docker 
#### 1- SQL Server In Docker -how run sql server container 
#####    -[Quickstart: Run SQL Server Linux container images with Docker](https://learn.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-ver16&pivots=cs1-powershell)
<code>
           > docker pull mcr.microsoft.com/mssql/server:2022-latest
           >docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=<YourPassw@0rd>" -p 1433:1433 --name sql-server --hostname localHost  -d mcr.microsoft.com/mssql/server:2022-latest
</code>
                
###    --To Connect from Any mssmt Where Enter "localHost,sql server auth,sa,<YourPassw@0rd>"

#### 2- postgre In Docker -how run postgre container 
<code>
              >docker pull postgres
              >docker run --name postgre-server -e POSTGRES_PASSWORD=<YourPassw@0rd> -d postgres
                   or use 
              >docker run --name postgre-server -e POSTGRES_USER=postgre -e POSTGRES_PASSWORD=<YourPassw@0rd> -p 5432:5432 -v /data:/var/lib/postgresql/data -d postgres
###                ----create container for pgadmin4
                >docker pull dpage/pgadmin4
                >docker run -p 80:80 -e PGADMIN_DEFAULT_EMAIL="test@domain.local" -e PGADMIN_DEFAULT_PASSWORD="admin" -d dpage/pgadmin4
###              or
               > docker run --name pgadmin4-server -e PGADMIN_DEFAULT_EMAIL="test@domain.local" -e PGADMIN_DEFAULT_PASSWORD="test1234" -p 8080:80 dpage/pgadmin4
 
</code>






