DROP TABLE IF EXISTS product;
CREATE TABLE product (
  id INT NOT NULL PRIMARY KEY,
  amount int NOT NULL,
  title varchar(100) NOT NULL,
  description varchar(255) DEFAULT NULL,
  is_gift BOOLEAN DEFAULT 0
);
INSERT INTO product (id, title, description, amount, is_gift)
VALUES (
    1,
    "Ergonomic Wooden Pants",
    "Deleniti beatae porro.",
    15157,
    0
  ),
  (
    2,
    "Ergonomic Cotton Keyboard",
    "Iste est ratione excepturi repellendus adipisci qui.",
    93811,
    0
  ),
  (
    3,
    "Gorgeous Cotton Chips",
    "Nulla rerum tempore rem.",
    60356,
    0
  ),
  (
    4,
    "Fantastic Frozen Chair",
    "Et neque debitis omnis quam enim cupiditate.",
    56230,
    0
  ),
  (
    5,
    "Incredible Concrete Soap",
    "Dolorum nobis temporibus aut dolorem quod qui corrupti.",
    42647,
    0
  ),
  (
    6,
    "Handcrafted Steel Towels",
    "Nam ea sed animi neque qui non quis iste.",
    900,
    1
  )