-- 1) film tablosunda bulunan title ve description sütunlarındaki verileri sıralayınız.
SELECT title, description
FROM film
ORDER BY title;

-- 2) film tablosunda bulunan tüm sütunlardaki verileri film uzunluğu (length) 60'dan büyük VE 75'ten küçük olma koşuluyla sıralayınız.
SELECT *
FROM film
WHERE length > 60 AND length < 75
ORDER BY length;

-- 3) film tablosunda bulunan tüm sütunlardaki verileri rental_rate 0.99 VE replacement_cost 12.99 VEYA 28.99 olma koşuluyla sıralayınız.
SELECT *
FROM film
WHERE rental_rate = 0.99 
  AND (replacement_cost = 12.99 OR replacement_cost = 28.99)
ORDER BY title;

-- 4) customer tablosunda bulunan first_name sütunundaki değeri 'Mary' olan müşterinin last_name sütunundaki değeri nedir?
SELECT last_name
FROM customer
WHERE first_name = 'Mary';

-- 5) film tablosundaki uzunluğu(length) 50'den büyük OLMAYIP aynı zamanda rental_rate değeri 2.99 veya 4.99 OLMAYAN verileri sıralayınız.
SELECT *
FROM film
WHERE length <= 50
  AND rental_rate NOT IN (2.99, 4.99)
ORDER BY length;

-- 6) film tablosunda bulunan tüm sütunlardaki verileri replacement_cost değeri 12.99 dan büyük eşit ve 16.99 küçük olma koşuluyla sıralayınız (BETWEEN - AND yapısını kullanınız.)
SELECT *
FROM film
WHERE replacement_cost BETWEEN 12.99 AND 16.99
ORDER BY replacement_cost;

-- 7) actor tablosunda bulunan first_name ve last_name sütunlarındaki verileri first_name 'Penelope' veya 'Nick' veya 'Ed' değerleri olması koşuluyla sıralayınız. (IN operatörünü kullanınız.)
SELECT first_name, last_name
FROM actor
WHERE first_name IN ('Penelope', 'Nick', 'Ed')
ORDER BY first_name;

-- 8) film tablosunda bulunan tüm sütunlardaki verileri rental_rate 0.99, 2.99, 4.99 VE replacement_cost 12.99, 15.99, 28.99 olma koşullarıyla sıralayınız. (IN operatörünü kullanınız.)
SELECT *
FROM film
WHERE rental_rate IN (0.99, 2.99, 4.99)
  AND replacement_cost IN (12.99, 15.99, 28.99)
ORDER BY title;

-- 9) country tablosunda bulunan country sütunundaki ülke isimlerinden 'A' karakteri ile başlayıp 'a' karakteri ile sonlananları sıralayınız.
SELECT country
FROM country
WHERE country LIKE 'A%a'
ORDER BY country;

-- 10) country tablosunda bulunan country sütunundaki ülke isimlerinden en az 6 karakterden oluşan ve sonu 'n' karakteri ile sonlananları sıralayınız.
SELECT country
FROM country
WHERE LENGTH(country) >= 6
  AND country LIKE '%n'
ORDER BY country;

-- 11) film tablosunda bulunan title sütunundaki film isimlerinden en az 4 adet büyük ya da küçük harf farketmesizin 'T' karakteri içeren film isimlerini sıralayınız.
SELECT title
FROM film
WHERE LENGTH(UPPER(title)) - LENGTH(REPLACE(UPPER(title), 'T', '')) >= 4
ORDER BY title;

-- 12) film tablosunda bulunan tüm sütunlardaki verilerden title 'C' karakteri ile başlayan ve uzunluğu (length) 90 dan büyük olan ve rental_rate 2.99 olan verileri sıralayınız.
SELECT *
FROM film
WHERE title LIKE 'C%'
  AND length > 90
  AND rental_rate = 2.99
ORDER BY title;

-- 13) film tablosunda bulunan replacement_cost sütununda bulunan birbirinden farklı değerleri sıralayınız.
SELECT DISTINCT replacement_cost
FROM film
ORDER BY replacement_cost;

-- 14) film tablosunda bulunan replacement_cost sütununda birbirinden farklı kaç tane veri vardır?
SELECT COUNT(DISTINCT replacement_cost) AS distinct_replacement_cost_count
FROM film;

-- 15) film tablosunda bulunan film isimlerinde (title) kaç tanesi T karakteri ile başlar ve aynı zamanda rating 'G' ye eşittir?
SELECT COUNT(*) AS count_title_starts_with_T_and_rating_G
FROM film
WHERE title LIKE 'T%' AND rating = 'G';

-- 16) country tablosunda bulunan ülke isimlerinden (country) kaç tanesi 5 karakterden oluşmaktadır?
SELECT COUNT(*) AS count_country_length_5
FROM country
WHERE LENGTH(country) = 5;

-- 17) city tablosundaki şehir isimlerinin kaç tanesi 'R' veya r karakteri ile biter?
SELECT COUNT(*) AS count_city_ends_with_r
FROM city
WHERE city ILIKE '%r';
