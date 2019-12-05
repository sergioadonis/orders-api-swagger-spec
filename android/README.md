# swagger-android-client

## Requirements

Building the API client library requires [Maven](https://maven.apache.org/) to be installed.

## Installation

To install the API client library to your local Maven repository, simply execute:

```shell
mvn install
```

To deploy it to a remote Maven repository instead, configure the settings of the repository and execute:

```shell
mvn deploy
```

Refer to the [official documentation](https://maven.apache.org/plugins/maven-deploy-plugin/usage.html) for more information.

### Maven users

Add this dependency to your project's POM:

```xml
<dependency>
    <groupId>io.swagger</groupId>
    <artifactId>swagger-android-client</artifactId>
    <version>1.0.0</version>
    <scope>compile</scope>
</dependency>
```

### Gradle users

Add this dependency to your project's build file:

```groovy
compile "io.swagger:swagger-android-client:1.0.0"
```

### Others

At first generate the JAR by executing:

    mvn package

Then manually install the following JARs:

* target/swagger-android-client-1.0.0.jar
* target/lib/*.jar

## Getting Started

Please follow the [installation](#installation) instruction and execute the following Java code:

```java

import io.swagger.client.api.BusinessApi;

public class BusinessApiExample {

    public static void main(String[] args) {
        BusinessApi apiInstance = new BusinessApi();
        Business bussines = new Business(); // Business | 
        try {
            Business result = apiInstance.createBusiness(bussines);
            System.out.println(result);
        } catch (ApiException e) {
            System.err.println("Exception when calling BusinessApi#createBusiness");
            e.printStackTrace();
        }
    }
}

```

## Documentation for API Endpoints

All URIs are relative to *https://virtserver.swaggerhub.com/sergioadonis/orders-api/1.0.1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BusinessApi* | [**createBusiness**](docs/BusinessApi.md#createBusiness) | **POST** /business | Create business
*BusinessApi* | [**deleteBusinessById**](docs/BusinessApi.md#deleteBusinessById) | **DELETE** /business/{id} | Delete business
*BusinessApi* | [**getBusinessById**](docs/BusinessApi.md#getBusinessById) | **GET** /business/{id} | Get business
*BusinessApi* | [**getBusinesses**](docs/BusinessApi.md#getBusinesses) | **GET** /business | Get businesses
*BusinessApi* | [**updateBusinessById**](docs/BusinessApi.md#updateBusinessById) | **PUT** /business/{id} | Update business


## Documentation for Models

 - [Business](docs/Business.md)
 - [Error](docs/Error.md)


## Documentation for Authorization

All endpoints do not require authorization.
Authentication schemes defined for the API:

## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issues.

## Author

sergio.adonis@outlook.com

