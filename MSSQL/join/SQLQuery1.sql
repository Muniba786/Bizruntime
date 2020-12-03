create database mysqlserver;
use mysqlserver;


CREATE TABLE candidates(
    id INT PRIMARY KEY IDENTITY,
    fullname VARCHAR(100) NOT NULL

);

CREATE TABLE employees(
    id INT PRIMARY KEY IDENTITY,
    fullname VARCHAR(100) NOT NULL
);


INSERT INTO 
    candidates(fullname)
VALUES
    ('John Doe'),
    ('Lily Bush'),
    ('Peter Drucker'),
    ('Jane Doe');


INSERT INTO 
    employees(fullname)
VALUES
    ('John Doe'),
    ('Jane Doe'),
    ('Michael Scott'),
    ('Jack Sparrow');


SELECT  
    c.id candidate_id,
    c.fullname candidate_name,
    e.id employee_id,
    e.fullname employee_name
FROM 
    candidates c
    INNER JOIN employees e 
        ON e.fullname = c.fullname;

SELECT  
	c.id candidate_id,
	c.fullname candidate_name,
	e.id employee_id,
	e.fullname employee_name
FROM 
	candidates c
	LEFT JOIN employees e 
		ON e.fullname = c.fullname;

SELECT  
    c.id candidate_id,
    c.fullname candidate_name,
    e.id employee_id,
    e.fullname employee_name
FROM 
    candidates c
    RIGHT JOIN employees e 
        ON e.fullname = c.fullname;

SELECT  
    c.id candidate_id,
    c.fullname candidate_name,
    e.id employee_id,
    e.fullname employee_name
FROM 
    candidates c
    FULL JOIN employees e 
        ON e.fullname = c.fullname;

SELECT * FROM candidates;

SELECT * FROM candidates
WHERE id='1' AND fullname='John Doe';


SELECT * FROM candidates
WHERE id='3' OR fullname='Lily Bush';

SELECT fullname
FROM candidates
GROUP BY fullname;





