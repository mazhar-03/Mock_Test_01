CREATE TABLE Country (
                         Id INT PRIMARY KEY,
                         Name VARCHAR(100) NOT NULL
);

CREATE TABLE Currency (
                          Id INT PRIMARY KEY,
                          Name VARCHAR(100) NOT NULL,
                          Rate FLOAT(3) NOT NULL  
);

CREATE TABLE Currency_Country (
                                  Country_Id INT,
                                  Currency_Id INT,
                                  PRIMARY KEY (Country_Id, Currency_Id),
                                  FOREIGN KEY (Country_Id) REFERENCES Country(Id),
                                  FOREIGN KEY (Currency_Id) REFERENCES Currency(Id)
);