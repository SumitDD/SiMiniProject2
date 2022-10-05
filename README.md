# SiMiniProject2

#### Made by: ####

* Phillip Thomas Isenborg Andersen, cph-pa124@cphbusiness.dk
* Sumit Dey, cph-sd152@cphbusiness.dk


## 1. Business process model

#### 1. The process ####

* A customer sends a complaint 
* A human within the business will read the complaint
* Depending on business rules it will be evaluted whether a answer is needed 
* A gateway that can take us two ways, either send a email as response if needed or archive the complaint.
* Finally the complaint will be resolved either with an answer or not.

![image](https://user-images.githubusercontent.com/55355481/194023767-03228bd7-06a5-41da-843f-0b829fb1ef81.png)


### Setup

**Step 1: Run the the command docker-compose up -d on both the redis and postgres .yml file**

The files are respectively located in the two folders  *Docker-postgres* and *Docker-redis* as shown below in the directory tree:

```
├── Docker-postgres
├── Docker-redis
├── Scripts
├── SiMiniProject2BPM
├── README.md
```

**Step 2: Run the following script in DBeaver or any other editor**

This will generate the following script:
```
CREATE TABLE Complaint (
	ID serial PRIMARY KEY,
	Email VARCHAR ( 50 ) UNIQUE NOT NULL,
	ComplaintMessage VARCHAR (255) NOT NULL
);
```

**Step 3: Open the project solution *SiMiniProject2BPM.sin* as shown below in the directory tree:

 
    ├── ...
    ├── SiMiniProject2BPM                   
    │   ├── SiMiniProject2BPM.sin        
    │   ├── ...       
    │   └── ...                
    └── ...




