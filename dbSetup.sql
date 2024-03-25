-- Active: 1711124626342@@35.87.147.206@3306@patient_sasquatch_480188_db
CREATE TABLE IF NOT EXISTS accounts (
    id VARCHAR(255) NOT NULL primary key COMMENT 'primary key', createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created', updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update', name varchar(255) COMMENT 'User Name', email varchar(255) COMMENT 'User Email', picture varchar(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';

CREATE TABLE dogs (
    id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, stray BOOLEAN DEFAULT false, color VARCHAR(25) NOT NULL, name VARCHAR(25) NOT NULL, size ENUM('small', 'medium', 'large') NOT NULL
);

--NOTE dummy data; just for this example usually not necessary

INSERT INTO
    dogs (stray, color, name, size)
VALUES (
        false, "brown", "MeatWad", "large"
    ),
    (
        true, "yellow", "Daisy", "small"
    ),
    (
        false, "brown", "Samantha", "medium"
    )

SELECT * FROM dogs;

DROP TABLE dogs;