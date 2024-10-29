# DatingAppV2

> A dating application designed to connect people, build profiles, and facilitate communication. DatingAppV2 includes authentication, profile management, and messaging.

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Technologies Used](#technologies-used)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Registration and Authentication**: Secure user registration and authentication using tokens.
- **User Profiles**: Users can create and edit their profiles.
- **Real-Time Messaging**: Enables real-time communication between users.
- **Matching System**: Algorithm to connect people with similar interests.
- **Intuitive UI**: User-friendly and accessible navigation design.

## Installation

### Prerequisites

- [.NET Core](https://dotnet.microsoft.com/download) (required version)
- [Node.js](https://nodejs.org/) and NPM as the package manager
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) for the database
- [Docker](https://www.docker.com/) (optional)

### Project Setup

1. Clone this repository:

    ```bash
    git clone https://github.com/leo7962/DatingAppV2.git
    cd DatingAppV2
    ```

2. Configure environment variables:

    - Create an `.env` file in the project root with your credentials and configuration details.
    - Example `.env` configuration:

        ```env
        DATABASE_URL=your_database_url
        JWT_SECRET=your_jwt_secret
        ```

3. Install dependencies:

    ```bash
    npm install
    ```

4. Start the application:

    ```bash
    npm start
    ```

5. Run database migrations and any necessary initial data seeding.

## Usage

To run the local server, execute:

```bash
npm run dev
```

Access the app at `http://localhost:3000`, where you can register or log in to start using it.

### Tests

To run unit tests, use:

```bash
npm test
```

Technologies Used
-----------------

-   **Backend**: .NET Core, Entity Framework, SQL Server
-   **Frontend**: Angular
-   **Authentication**: JWT (JSON Web Token)
-   **Database**: SQL Server
-   **Containers**: Docker (optional)
-   **Package Manager**: NPM

Contributing
------------

1.  Fork the repository.
2.  Create a new branch (`git checkout -b feature/new-feature`).
3.  Commit your changes (`git commit -m 'Add new feature'`).
4.  Push to the branch (`git push origin feature/new-feature`).
5.  Open a Pull Request.

License
-------

This project is licensed under the GPL-3.0 License - see the LICENSE file for details.
