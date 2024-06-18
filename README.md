# 🚆 TrainCloud.Models

The `TrainCloud.Models` library provides classes and base class which are used in all services and applications. 

* Enabled (Tenant)-Features
* TokenModel for authorization and authentication
* Paging and filtering of service models in the microservices

## Status

### GitHub Actions
[![SonarQube](https://github.com/traincloud-net/TrainCloud.Models/actions/workflows/sonarqube.yml/badge.svg)](https://github.com/traincloud-net/TrainCloud.Models/actions/workflows/sonarqube.yml) 
[![NuGet](https://github.com/traincloud-net/TrainCloud.Models/actions/workflows/nuget.yml/badge.svg)](https://github.com/traincloud-net/TrainCloud.Models/actions/workflows/nuget.yml) 

### SonarQube
[![Bugs](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Models&metric=bugs&token=sqb_54c03c28f976684cdbed8800e1b14fb632f158e4)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Models)
[![Code Smells](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Models&metric=code_smells&token=sqb_54c03c28f976684cdbed8800e1b14fb632f158e4)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Models) 
[![Duplicated Lines (%)](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Models&metric=duplicated_lines_density&token=sqb_54c03c28f976684cdbed8800e1b14fb632f158e4)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Models) 
[![Lines of Code](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Models&metric=ncloc&token=sqb_54c03c28f976684cdbed8800e1b14fb632f158e4)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Models) 
[![Maintainability Rating](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Models&metric=sqale_rating&token=sqb_54c03c28f976684cdbed8800e1b14fb632f158e4)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Models) 
[![Reliability Rating](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Models&metric=reliability_rating&token=sqb_54c03c28f976684cdbed8800e1b14fb632f158e4)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Models) 
[![Security Hotspots](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Models&metric=security_hotspots&token=sqb_54c03c28f976684cdbed8800e1b14fb632f158e4)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Models) 
[![Security Rating](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Models&metric=security_rating&token=sqb_54c03c28f976684cdbed8800e1b14fb632f158e4)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Models) 
[![Technical Debt](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Models&metric=sqale_index&token=sqb_54c03c28f976684cdbed8800e1b14fb632f158e4)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Models) 
[![Vulnerabilities](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Models&metric=vulnerabilities&token=sqb_54c03c28f976684cdbed8800e1b14fb632f158e4)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Models)

## How to use

Add the TrainCloud NuGet Feed to you `nuget.config` file.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
		<packageSources>
				<add key="TrainCloud" value="https://nuget.pkg.github.com/traincloud-net/index.json" />
		</packageSources>
</configuration>
```

Add `TrainCloud.Models` package to the project

```bash
dotnet add package TrainCloud.Models
```