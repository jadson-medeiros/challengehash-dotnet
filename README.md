# challengehash-dotnet

## Introduction

This project proposes a microservice that display a product list to requested.

## Flow

The project has a web service with only one endpoint: "/checkout".
This endpoint expect to receive list of products id and quantity as request. This service will get all the products from database and will calculate the price.
Will calculate the total purchase expense and return to the user. And finaly the service will response the request with a json of all products and the total purchase.

## How to execute / Deploy

### Requirements

- docker
- docker-compose

```sh
git clone https://github.com/jadson-medeiros/challengehash-dotnet

cd challengehash-dotnet

docker-compose up -d
```
