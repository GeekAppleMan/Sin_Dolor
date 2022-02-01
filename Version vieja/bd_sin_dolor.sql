-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 18-01-2022 a las 18:57:18
-- Versión del servidor: 10.4.21-MariaDB
-- Versión de PHP: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_sin_dolor`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_almacen`
--

CREATE TABLE `tb_almacen` (
  `id_almacen` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_consulta`
--

CREATE TABLE `tb_consulta` (
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `paciente` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_consulta`
--

INSERT INTO `tb_consulta` (`fecha`, `hora`, `paciente`) VALUES
('2021-02-02', '12:12:00', 'fulano');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_pacientes`
--

CREATE TABLE `tb_pacientes` (
  `id_paciente` int(11) NOT NULL,
  `nombre` text NOT NULL,
  `domicilio` text NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `telefono` int(11) NOT NULL,
  `recomendado_por` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_pacientes`
--

INSERT INTO `tb_pacientes` (`id_paciente`, `nombre`, `domicilio`, `fecha_nacimiento`, `telefono`, `recomendado_por`) VALUES
(29, 'Ivan', 'Garcia', '0000-00-00', 2147483647, 'gabs@gmail.com'),
(38, 'gabs', 'aqui', '2022-01-13', 2147483647, 'Nadie');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_productos`
--

CREATE TABLE `tb_productos` (
  `id_producto` int(11) NOT NULL,
  `nombre` text NOT NULL,
  `descripcion` text NOT NULL,
  `precio` text NOT NULL,
  `foto` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_productos`
--

INSERT INTO `tb_productos` (`id_producto`, `nombre`, `descripcion`, `precio`, `foto`) VALUES
(6, 'sabritas', 'botana', '40', 'sabritas.jpg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_usuarios`
--

CREATE TABLE `tb_usuarios` (
  `id_usuario` int(5) NOT NULL,
  `usuario` varchar(30) NOT NULL,
  `password` varchar(200) NOT NULL,
  `id_privilegio` int(5) NOT NULL,
  `activacion` tinyint(1) DEFAULT 1,
  `last_session` datetime DEFAULT NULL,
  `token` varchar(40) NOT NULL,
  `token_password` varchar(100) NOT NULL,
  `password_request` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tb_usuarios`
--

INSERT INTO `tb_usuarios` (`id_usuario`, `usuario`, `password`, `id_privilegio`, `activacion`, `last_session`, `token`, `token_password`, `password_request`) VALUES
(1, 'admin', '$2y$10$4kaCxykE1NfBSagMYRarQ.HoeimJC05XqYkNSWgU0E59oUioqu46W', 1, 1, '2021-12-06 10:51:37', '86758a739c8400f17941db1b805e2331', '', 0),
(2, 'gabs', '$2y$10$4kaCxykE1NfBSagMYRarQ.HoeimJC05XqYkNSWgU0E59oUioqu46W', 1, 1, '2021-12-08 10:14:59', '$2y$10$4kaCxykE1NfBSagMYRarQ.HoeimJC05Xq', '', 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tb_almacen`
--
ALTER TABLE `tb_almacen`
  ADD PRIMARY KEY (`id_almacen`);

--
-- Indices de la tabla `tb_pacientes`
--
ALTER TABLE `tb_pacientes`
  ADD PRIMARY KEY (`id_paciente`);

--
-- Indices de la tabla `tb_productos`
--
ALTER TABLE `tb_productos`
  ADD PRIMARY KEY (`id_producto`);

--
-- Indices de la tabla `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `user` (`usuario`),
  ADD KEY `id_privilegio` (`id_privilegio`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tb_almacen`
--
ALTER TABLE `tb_almacen`
  MODIFY `id_almacen` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tb_pacientes`
--
ALTER TABLE `tb_pacientes`
  MODIFY `id_paciente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT de la tabla `tb_productos`
--
ALTER TABLE `tb_productos`
  MODIFY `id_producto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  MODIFY `id_usuario` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
