# Design Patterns - Composite

This repository showcases an implementation of the Composite design pattern in C#. The code demonstrates how to compose objects into tree structures to represent part-whole hierarchies, allowing clients to treat individual objects and compositions uniformly. This pattern is ideal for scenarios where you need to work with tree-like structures and simplify operations by treating individual objects and their compositions the same.

## Table of Contents
1. [Introduction](#introduction)
2. [Implementation Overview](#implementation-overview)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Contributing](#contributing)
6. [License](#license)
7. [Contact](#contact)

## Introduction
The Composite design pattern is a structural pattern that lets you compose objects into tree-like structures to represent part-whole hierarchies. This pattern allows you to treat individual objects and groups of objects uniformly, which simplifies client code when dealing with complex hierarchical structures.

## Implementation Overview
This repository provides a C# implementation of the Composite design pattern. Key components of the code include:

- **IComponent Interface**: Defines the common interface for both leaf and composite classes.
- **Leaf Class**: Represents individual objects in the composition.
- **Composite Class**: Represents a collection of `IComponent` objects, allowing them to be managed as a single unit.
- **Program Class**: Demonstrates how to create and display a composite structure, showcasing the pattern in action.

## Installation
To get started with this project, clone the repository to your local machine:

```bash
git clone https://github.com/MansourJouya/DesignPattern-Composite.git
```

Navigate into the project directory:

```bash
cd DesignPattern-Composite
```

Open the solution in Visual Studio or your preferred C# development environment to explore the implementation.

## Usage
1. Open the solution file (.sln) in your C# development environment.
2. Run the `Program` class to see the Composite pattern in action.
3. Modify the `Leaf` and `Composite` classes or add new components to customize the demonstration or expand the structure.

## Contributing
Contributions are welcome! If you would like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch (e.g., `git checkout -b feature/YourFeature`).
3. Make your changes and commit them (e.g., `git commit -m "Add some feature"`).
4. Push to the branch (e.g., `git push origin feature/YourFeature`).
5. Open a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE.txt) file for details.

## Contact
For any inquiries, feel free to reach out at jouya.m@gmail.com.

