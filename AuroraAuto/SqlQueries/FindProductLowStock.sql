SELECT
*
FROM
dbo.Product
WHERE
CategoryID = 5

AND Stock<20
ORDER BY
ProductName;