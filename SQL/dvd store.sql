-- month | total_count | total_amount | mike_count | mike_amount | jon_count | jon_amount
SELECT EXTRACT(
    MONTH
    FROM payment_date
  ) AS month,
  COUNT(*) AS total_count,
  SUM(amount) AS total_amount,
  COUNT(
    CASE
      WHEN staff_id = 1 THEN 1
    END
  ) AS mike_count,
  SUM(
    CASE
      WHEN staff_id = 1 THEN amount
      ELSE 0
    END
  ) AS mike_amount,
  COUNT(
    CASE
      WHEN staff_id = 2 THEN 1
    END
  ) AS jon_count,
  SUM(
    CASE
      WHEN staff_id = 2 THEN amount
      ELSE 0
    END
  ) AS jon_amount
FROM payment
GROUP BY EXTRACT(
    MONTH
    FROM payment_date
  )
ORDER BY month;