use world

select * from City
select * from Country

-- 1
select * from City
where CountryCode = 'EGY'

-- 2 
select [Name] from Country
where Country.Code in(
select CountryCode from City
where Population > 5000000)

-- 3
select [Name] from Country
where Code in 
(select CountryCode from CountryLanguage
where Language = 'Dutch' and isOfficial = 0)

-- 4
select [Name], [Language] 
from CountryLanguage
join Country on CountryLanguage.CountryCode = Country.Code
where IsOfficial = 1

-- 5
select Name, District from City
where District in 
(
	select District from City
	group by district
	having count(name) > 1
)


-- 6
select Country.Name, count(*) from Country
join City on Country.Code = City.CountryCode
where Continent = 'Africa'
group by Country.Name

-- 7
select Country.Name, Code, count(Code)
from
Country join CountryLanguage on Code = CountryCode
where CountryLanguage.IsOfficial = 0
group by Country.Name, Country.Code


-- 8
select Name from Country
where Code in 
(select CountryCode from CountryLanguage
where IsOfficial = 1
group by CountryCode
having count(*) > 1)

-- 9


-- 10
select Country.Name , Count(*) as 'Number of Cities'
from Country join City on Country.Code = City.CountryCode
where Country.Population > 1000000000
group by Country.Name

-- 11
select Name from Country
where Population in 
(select max(Population) from Country)

-- 12
create table WaterResource (
	ID int identity primary key,
	CountryCode char(3),
	Type varchar(10),
	Name varchar(20)

	constraint water_country_fk
	foreign key (CountryCode) references Country(Code)
)

-- 13
insert into WaterResource(CountryCode, Type, Name)
values('EGY', 'River', 'Nile River')

select * from WaterResource
