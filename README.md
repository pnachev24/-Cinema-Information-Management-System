# Information Management System (Cinema)

This C# application utilizes DataGridView control for data filtering in a cinema management system.

## Overview

This application consists of two forms:

1. **Form2**: This form serves as the login interface where users can authenticate themselves.
2. **Form1**: This form displays cinema data in a DataGridView control and allows users to filter the data based on various criteria.

## Additional Features

### Form1

- **Filtering**: Users can filter cinema data based on status, room type, availability, and room number.
- **Clear Filters**: Users can clear applied filters with a single click.
- **Check-In**: Users can initiate the check-in process for booking a room.

### Form2

- **Login**: Users can log in to access the application.
- **Authentication**: Validates user credentials before granting access to the application.

### check_in Form

- **Validation**: Validates phone number input to ensure it's at least 10 characters long.
- **Booking**: Allows users to book a room if it's available.
- **Database Interaction**: Inserts booking information into the database and updates room availability status accordingly.

## Database Schema

The application interacts with the following tables in the database:

1. **Cinema**: Contains information about cinema rooms including room number, status, room type, and availability.
2. **CheckInInformation**: Stores booking information including room number, guest name, phone number, check-in date, and check-out date.

## Prerequisites

Before running the application, ensure that you have the following:

- Microsoft Visual Studio or any compatible C# IDE.
- Access to a SQL Server database containing cinema data.

