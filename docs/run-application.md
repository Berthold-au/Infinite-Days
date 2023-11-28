# Running the Application

This document provides instructions on how to run the Infinite Days Challenge app locally and using Docker Compose.

## Prerequisites

Before testing the application, ensure you have the following prerequisites installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) for building and running the .NET 8 application.
- [Docker](https://www.docker.com/get-started) for running the application in a Docker container.

## Run Locally

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/dotnetcameroon/Infinite-Days.git
   cd Infinite-Days
   ```

2. **Build and Run the Application:**
    ```bash
    dotnet run --project src/ui
    ```

## Running with Docker Compose `(Beta)`

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/dotnetcameroon/Infinite-Days.git
   cd Infinite-Days
   ```

2. **Run the Application with Docker Compose:**
    ```bash
    docker-compose up
    ```
