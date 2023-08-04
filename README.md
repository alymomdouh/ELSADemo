# ELSADemo

## Use This WebSite To Test Docker 

#### 1- SQL Server In Docker -how run sql server container 
#####    -(Quickstart: Run SQL Server Linux container images with Docker)[https://learn.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-ver16&pivots=cs1-powershell]
 <code>
        > docker pull mcr.microsoft.com/mssql/server:2022-latest
        >docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=<YourPassw@0rd>" -p 1433:1433 --name sql-server --hostname localHost  -d mcr.microsoft.com/mssql/server:2022-latest
        --To Connect from Any mssmt Where Enter "localHost,sql server auth,sa,<YourPassw@0rd>"
 </code>






