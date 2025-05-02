INSERT INTO Country (Id, Name) VALUES
                                   (1, 'Germany'),
                                   (2, 'France'),
                                   (3, 'Poland'),
                                   (4, 'United States');

INSERT INTO Currency (Id, Name, Rate) VALUES
                                          (1, 'Euro', 1.09),
                                          (2, 'Polish Zloty', 0.26),
                                          (3, 'US Dollar', 1.00);

INSERT INTO Currency_Country (Country_Id, Currency_Id) VALUES
                                                           (1, 1), -- Germany uses Euro
                                                           (2, 1), -- France uses Euro
                                                           (3, 2), -- Poland uses Polish Zloty
                                                           (4, 3); -- USA uses US Dollar
