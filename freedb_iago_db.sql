
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

CREATE TABLE `timeout` (
  `id` int NOT NULL,
  `tempo_limite` int NOT NULL,
  `tempo_requisicao` int NOT NULL,
  `tipo_calculo` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

ALTER TABLE `timeout`
  ADD PRIMARY KEY (`id`);
  
ALTER TABLE `timeout`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;
COMMIT;
