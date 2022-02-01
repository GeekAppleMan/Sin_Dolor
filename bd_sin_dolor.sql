-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 31-01-2022 a las 19:44:09
-- Versión del servidor: 10.4.22-MariaDB
-- Versión de PHP: 8.1.1

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
  `id_producto` varchar(255) NOT NULL,
  `cantidad` varchar(255) NOT NULL,
  `fecha` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_almacen`
--

INSERT INTO `tb_almacen` (`id_almacen`, `id_producto`, `cantidad`, `fecha`) VALUES
(1, ' 12', '2', '31/01/2022'),
(2, ' 12', '5', '31/01/2022'),
(3, ' 12', '5', '31/01/2022'),
(4, ' 13', '10', '31/01/2022'),
(5, ' 12', '2', '31/01/2022');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_consulta`
--

CREATE TABLE `tb_consulta` (
  `fecha` varchar(255) NOT NULL DEFAULT current_timestamp(),
  `hora` varchar(255) NOT NULL DEFAULT current_timestamp(),
  `paciente` varchar(255) NOT NULL,
  `tratamiento` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_consulta`
--

INSERT INTO `tb_consulta` (`fecha`, `hora`, `paciente`, `tratamiento`) VALUES
('2021-02-02', '12:12:00', 'fulano', ''),
(' 31/01/2022', '11', '29', 'habdjashdasd'),
(' 31/01/2022', '11', '29', 'habdjashdasd'),
(' 31/01/2022', '11', '29', 'Hola'),
(' 31/01/2022', '11', '29', 'hellouda'),
(' 31/01/2022', '11', '29', 'asdasd'),
(' 31/01/2022', '11:36', '29', 'sdasd'),
('28/02/2022', '11:37', 'hola', 'hola');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_pacientes`
--

CREATE TABLE `tb_pacientes` (
  `id_paciente` int(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `domicilio` varchar(255) NOT NULL,
  `fecha_nacimiento` varchar(255) NOT NULL,
  `telefono` varchar(255) NOT NULL,
  `recomendado_por` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_pacientes`
--

INSERT INTO `tb_pacientes` (`id_paciente`, `nombre`, `domicilio`, `fecha_nacimiento`, `telefono`, `recomendado_por`) VALUES
(29, 'Ivan', 'Garcia', '0000-00-00', '2147483647', 'gabs@gmail.com'),
(38, 'gabs', 'aqui', '2022-01-13', '2147483647', 'Nadie');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_productos`
--

CREATE TABLE `tb_productos` (
  `id_producto` int(11) NOT NULL,
  `codigo` varchar(255) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `descripcion` varchar(255) NOT NULL,
  `precio` varchar(255) NOT NULL,
  `cantidad` varchar(255) NOT NULL,
  `foto` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_productos`
--

INSERT INTO `tb_productos` (`id_producto`, `codigo`, `nombre`, `descripcion`, `precio`, `cantidad`, `foto`) VALUES
(11, '4', 'colacoca', 'la misma pero con cantidad', '40', '60', 'C:/Users/Jaime/Desktop/Git_hub_sindolor/Sin_Dolor/Imagenes/cocacola.jpg'),
(12, '2', 'gansito', 'el pato de recuerdame con cubierta de chocolate', '15', '32', 'C:/Users/Jaime/Desktop/Git_hub_sindolor/Sin_Dolor/Imagenes/gansito.jpg'),
(13, '3', 'pinguios marinela', 'no son pinguinos de verdad, son panecitos de chocolate rellenos de crema', '17', '51', 'C:/Users/Jaime/Desktop/Git_hub_sindolor/Sin_Dolor/Imagenes/pingus.jpg');

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
  `last_session` varchar(255) DEFAULT NULL,
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
  MODIFY `id_almacen` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `tb_pacientes`
--
ALTER TABLE `tb_pacientes`
  MODIFY `id_paciente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT de la tabla `tb_productos`
--
ALTER TABLE `tb_productos`
  MODIFY `id_producto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  MODIFY `id_usuario` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
