# Dynamic-JSON-Editor

**A tool to simplify editing JSON files.**

> **<span style="color: red"> DISCLAIMER </span>** This README describes features that we plan to include. We are working on those features.  
If you want to check the progress please go to the [project page](https://github.com/VitoBarra/Dynamic-JSON-Editor/projects?type=classic).

## Idea

The user has to specify a set of rules or give an example file to declare the structure of the JSON.  
The software will then create one or multiple forms usable to populate JSON files, moreover, the software will perform data validation based on the said rules.

## Capabilities

The software will support every type of attribute usable in normal JSON files including:
- Nested objects
- Arrays
- Every type of simple attribute

## Usage

### Current Version

1. Import an example JSON file created with the structure dat you wnat.  
E.g.
```JSON
    [
        {
            id: 42,
            userData: {
                name: "Douglas",
                surname: "Adams",
                age: 49,
                genius: true,
            },
            operas: [
                "The Hitchhiker's Guide to the Galaxy",
                "Dirk Gently"
            ]
        }
    ]
```

2. Let the software process the file.
3. Use the given form to write the new JSON.  
E.g.  
**SCREEN FORM**

### Ideal Version

> Other than the currently supported way to create the form we will add a new system.

1. Create the data strcture using the given tools
2. Write the rules to allow for data validation.
3. Let the software process the rules.
4. Use the giver form to write the new JSON.