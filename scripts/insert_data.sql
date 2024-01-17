INSERT INTO [dbo].[EmployeesTable] ([ID], [Name], [Department], [Date of Birth], [Hourly Rate])
VALUES
    (1, 'John Doe', 'Patrol Division', '1985-04-15', 20.50, 0, 11),
    (2, 'Jane Smith', 'Investigations Division', '1978-09-22', 25.75, 1, 22),
    (3, 'Mike Johnson', 'Special Operations', '1965-07-08', 15.00, 1, 33),
    (4, 'Emily Davis', 'Highway Patrol', '1990-03-14', 22.25, 1, 44),
    (5, 'Robert White', 'Community Services', '1973-11-30', 18.50, 1, 55),
    (6, 'Jessica Brown', 'Crime Scene Units', '1980-02-17', 30.00, 1, 66),
    (7, 'David Wilson', 'Administrative Division', '1968-08-03', 12.75, 1, 77),
    (8, 'Ashley Turner', 'Internal Affairs', '1982-04-26', 28.00, 1, 88),
    (9, 'Brian Miller', 'Patrol Division', '1977-01-10', 17.50, 1, 99),
    (10, 'Megan Harris', 'Special Operations', '1989-09-18', 23.50, 1, 1010);

INSERT INTO [dbo].[CasesTable] ([No], [Type of Case], [Status], [Description], [Date of Modification])
VALUES
    (1, 'Violent Crimes', 'Active', 'Case of violent crime currently under investigation.', '2015-05-15'),
    (2, 'Property Crimes', 'Inactive', 'Property crime case with no recent activity.', '2016-09-22'),
    (3, 'Drug-Related Offenses', 'Reopened', 'Case related to drug offenses has been reopened.', '2017-07-08'),
    (4, 'Domestic Violence', 'Pending', 'Domestic violence case awaiting further action.', '2018-03-14'),
    (5, 'Sexual Crimes', 'Cleared', 'Sexual crime case has been cleared and resolved.', '2019-11-30'),
    (6, 'Traffic Violations', 'Administrative Closure', 'Traffic violation case closed administratively.', '2020-02-17'),
    (7, 'Cyber Crimes', 'Pending Prosecution', 'Case involving cyber crimes pending prosecution.', '2021-08-03'),
    (8, 'Missing Persons', 'Awaiting Trial', 'Case involving missing persons awaiting trial.', '2022-04-26'),
    (9, 'Public Order Offenses', 'Solved', 'Public order offense case has been solved.', '2023-01-10'),
    (10, 'Violent Crimes', 'Active', 'Another case of violent crime currently under investigation.', '2023-09-18');

INSERT INTO [dbo].[ShiftsTable] ([ID], [Shift], [Date])
VALUES
    (1, 'Night Shift', '2024-01-05'),
    (2, 'Morning Shift', '2024-02-10'),
    (3, 'Daytime Shift', '2024-01-15'),
    (4, 'Evening Shift', '2024-02-20'),
    (5, 'Night Shift', '2024-01-25'),
    (6, 'Morning Shift', '2024-02-01'),
    (7, 'Daytime Shift', '2024-01-08'),
    (8, 'Evening Shift', '2024-02-13'),
    (9, 'Night Shift', '2024-01-20'),
    (10, 'Morning Shift', '2024-02-05');

INSERT INTO [dbo].[InventoryTable] ([S No], [Police Inventory], [Inventory Type], [Quantity])
VALUES
    (1, 'Handgun', 'Weapons and Ammunition', 50),
    (2, 'Radio Set', 'Communication Devices', 30),
    (3, 'Bulletproof Vest', 'Protective Gear', 100),
    (4, 'Police Car', 'Vehicles', 20),
    (5, 'Laptop', 'Technology and Tools', 15),
    (6, 'Notepads', 'Office Supplies', 200),
    (7, 'Training Dummy', 'Training Equipment', 10),
    (8, 'First Aid Kit', 'Medical Supplies', 50),
    (9, 'Flashlights', 'Miscellaneous', 40),
    (10, 'Shotgun', 'Weapons and Ammunition', 30);
