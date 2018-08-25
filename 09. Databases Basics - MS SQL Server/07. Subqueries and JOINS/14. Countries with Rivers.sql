SELECT TOP (5) c.CountryName, r.RiverName 
FROM CountriesRivers AS cr
FULL JOIN Countries AS c ON
c.CountryCode = cr.CountryCode
FULL JOIN Rivers AS r ON 
r.Id = cr.RiverId
JOIN Continents AS co ON
c.ContinentCode = co.ContinentCode
WHERE  co.ContinentName = 'Africa'
ORDER BY  c.CountryName

