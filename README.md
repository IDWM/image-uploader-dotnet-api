# Image Uploader Setup Guide

This is an Image Uploader project that allows you to upload and manage images.

## Prerequisites

Before you begin, make sure you have the following installed:

- [.NET Core SDK](https://dotnet.microsoft.com/download)

## Clone the Project

```bash
git clone <project-repository-url>
```

## Create the appsettings File

Create a file named `appsettings.json` in the project root and paste the following content:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data source=image-uploader.db"
  },
  "CloudinarySettings": {
    "CloudName": "your_cloud_name",
    "ApiKey": "your_api_key",
    "ApiSecret": "your_api_secret"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

## Configure Cloudinary Credentials

1. Create an account on [Cloudinary](https://cloudinary.com/).
2. Replace `your_cloud_name`, `your_api_key`, and `your_api_secret` in the `CloudinarySettings` section with your actual Cloudinary credentials.

## Install .NET Dependencies

Navigate to the project directory and execute the following command to install .NET dependencies:

```bash
dotnet restore
```

## Run the Project

Execute the following command to start the project:

```bash
dotnet run
```

The application will be available at `http://localhost:5000`.

### Additional Notes

- Make sure to replace `your_cloud_name`, `your_api_key`, and `your_api_secret` in the `appsettings.json` file with your actual Cloudinary credentials.
- If you're using different environments (e.g., production), create corresponding environment files and adjust the configuration accordingly.

For more information about the .NET Core SDK and project setup, refer to the [.NET Core SDK Documentation](https://dotnet.microsoft.com/download).
