-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-02-2019 a las 18:48:16
-- Versión del servidor: 10.1.37-MariaDB
-- Versión de PHP: 7.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `12204-dm2e`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `caracteristicas`
--

CREATE TABLE `caracteristicas` (
  `id` int(11) NOT NULL,
  `nombre` varchar(30) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `caracteristicas`
--

INSERT INTO `caracteristicas` (`id`, `nombre`) VALUES
(10, 'Azul'),
(9, 'Black'),
(7, 'Rojo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categorias`
--

CREATE TABLE `categorias` (
  `id` int(11) NOT NULL,
  `nombre` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish_ci NOT NULL,
  `superior` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `categorias`
--

INSERT INTO `categorias` (`id`, `nombre`, `superior`) VALUES
(1, 'Portatiles', 0),
(2, 'Smartphones', 0),
(3, 'Tablets', 0),
(4, 'Televisores', 0),
(5, 'Consolas', 0),
(6, 'Perifericos', 0),
(7, 'Workstation', 1),
(8, 'Gaming', 1),
(9, 'IOS', 2),
(10, 'Android', 2),
(11, 'Tablet', 3),
(12, 'Ebook', 3),
(13, 'LED', 4),
(14, 'Smart TV', 4),
(15, 'Sobremesa', 5),
(16, 'Portatil', 5),
(17, 'Teclado', 6),
(18, 'Cascos', 6),
(22, 'Prueba', 0),
(25, 'sub prueba', 22);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cate_carac`
--

CREATE TABLE `cate_carac` (
  `id_cat` int(11) NOT NULL,
  `id_car` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `cate_carac`
--

INSERT INTO `cate_carac` (`id_cat`, `id_car`) VALUES
(7, 7),
(8, 7),
(11, 9),
(11, 10),
(12, 10),
(15, 9),
(16, 9),
(18, 7),
(18, 9),
(18, 10);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `formularios`
--

CREATE TABLE `formularios` (
  `nombre` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `correo` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `telefono` int(9) NOT NULL,
  `usuario` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `mensaje` varchar(200) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `formularios`
--

INSERT INTO `formularios` (`nombre`, `correo`, `telefono`, `usuario`, `mensaje`) VALUES
('Angel', 'angel@angel.es', 620000000, 'angel', 'Hola mundo'),
('Javi', 'javi@javi.es', 610000000, 'javi', 'Hola Mundo!!'),
('Oscar', 'oscar@oscar.es', 600000000, 'oscar', 'Hola mundo'),
('tanvir', 'tanvir@tanvir.es', 600000000, 'tanvir', 'hola mundo'),
('Xavi', 'xavi@xavi.es', 600000000, 'xavi', 'Has iniciado una sesi?n de inc?gnito');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `marca` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `foto` varchar(100) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id`, `nombre`, `marca`, `foto`) VALUES
(1, 'ZBook 17 G4', 'HP', 'images/ZBook17G4.jpg'),
(2, 'iPhone X', 'Apple', 'images/iphonex.jpg'),
(3, 'MSI GE63 Raider', 'Msi', 'images/msi_ge63.jpg'),
(4, 'Galaxy S9', 'Samsung', 'images/s9.jpg'),
(5, 'Galaxy Note9', 'Samsung', 'images/note9.jpg'),
(6, 'iPhone XS', 'Apple', 'images/iphonexs.jpg'),
(7, 'LG OLED55C8PLA', 'LG', 'images/lgstv.jpg'),
(8, 'Samsung UE32M5505', 'Samsung', 'images/sled.jpg'),
(9, 'iPad Pro', 'Apple', 'images/ipadpro.jpg'),
(10, 'Paperwhite 2018', 'Kindle', 'images/kindle.jpg'),
(11, 'Playstation Vita', 'Sony', 'images/psvita.jpg'),
(12, 'XBox One S', 'Microsoft', 'images/xboxones.jpg'),
(13, 'Beats Studio3', 'Beats', 'images/beats.png'),
(14, 'BlackWidow Chroma V2', 'Razer', 'images/razer.jpg'),
(15, 'Macbook Air 2018', 'Apple', 'images/macair.jpg'),
(20, 'prueba', 'prueba', 'prueba'),
(21, 'prueba2', 'p', 'p');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto_categoria`
--

CREATE TABLE `producto_categoria` (
  `id_pro` int(11) NOT NULL,
  `id_cat` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `producto_categoria`
--

INSERT INTO `producto_categoria` (`id_pro`, `id_cat`) VALUES
(1, 7),
(2, 9),
(3, 8),
(4, 10),
(5, 10),
(6, 9),
(7, 13),
(8, 14),
(9, 11),
(10, 12),
(11, 16),
(12, 15),
(13, 18),
(14, 17),
(15, 7),
(20, 7),
(20, 9),
(20, 25),
(21, 25);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto_tienda`
--

CREATE TABLE `producto_tienda` (
  `id_tienda` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `precio` decimal(20,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `producto_tienda`
--

INSERT INTO `producto_tienda` (`id_tienda`, `id_producto`, `precio`) VALUES
(1, 1, '4690.96'),
(1, 5, '1069.00'),
(1, 6, '1262.07'),
(1, 12, '285.00'),
(2, 2, '939.00'),
(2, 8, '399.00'),
(2, 9, '899.00'),
(2, 13, '349.95'),
(2, 15, '1259.00'),
(3, 3, '1499.99'),
(3, 7, '1579.00'),
(3, 10, '129.99'),
(3, 11, '130.80'),
(3, 14, '119.00'),
(3, 20, '123456.00'),
(3, 21, '123445.00'),
(4, 4, '669.90');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tiendaonline`
--

CREATE TABLE `tiendaonline` (
  `id` int(11) NOT NULL,
  `url` varchar(100) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `tiendaonline`
--

INSERT INTO `tiendaonline` (`id`, `url`) VALUES
(1, 'www.pccomponentes.com'),
(3, 'www.amazon.com'),
(6, 'www.aa.bb');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tiendas`
--

CREATE TABLE `tiendas` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `tipo` varchar(20) COLLATE utf8_spanish_ci NOT NULL,
  `latitud` varchar(15) COLLATE utf8_spanish_ci NOT NULL,
  `longitud` varchar(15) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `tiendas`
--

INSERT INTO `tiendas` (`id`, `nombre`, `tipo`, `latitud`, `longitud`) VALUES
(1, 'PcComponentes', 'Online', '40.4053925', '-3.6763777'),
(2, 'El Corte Ingles', 'Fisica', '41.3818', '2.1685'),
(3, 'Amazon', 'Online', '37.3914105', '-5.9591776'),
(4, 'Fnac', 'Fisica', '43.2603479', '-2.9334110'),
(6, 'Efecto2000', 'Online', '40.4016514', '-3.6768074'),
(8, 'Media Markt', 'Fisica', '40.4252139', '-3.6768385');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `caracteristicas`
--
ALTER TABLE `caracteristicas`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nombre` (`nombre`);

--
-- Indices de la tabla `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nombre` (`nombre`);

--
-- Indices de la tabla `cate_carac`
--
ALTER TABLE `cate_carac`
  ADD PRIMARY KEY (`id_cat`,`id_car`),
  ADD KEY `cate_carac_ibfk_2` (`id_car`);

--
-- Indices de la tabla `formularios`
--
ALTER TABLE `formularios`
  ADD PRIMARY KEY (`correo`),
  ADD UNIQUE KEY `usuario` (`usuario`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `producto_categoria`
--
ALTER TABLE `producto_categoria`
  ADD PRIMARY KEY (`id_pro`,`id_cat`),
  ADD KEY `producto_categoria_ibfk_2` (`id_cat`);

--
-- Indices de la tabla `producto_tienda`
--
ALTER TABLE `producto_tienda`
  ADD PRIMARY KEY (`id_tienda`,`id_producto`,`precio`),
  ADD KEY `producto_tienda_ibfk_2` (`id_producto`);

--
-- Indices de la tabla `tiendaonline`
--
ALTER TABLE `tiendaonline`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `tiendas`
--
ALTER TABLE `tiendas`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nombre` (`nombre`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `caracteristicas`
--
ALTER TABLE `caracteristicas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `categorias`
--
ALTER TABLE `categorias`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT de la tabla `tiendaonline`
--
ALTER TABLE `tiendaonline`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `tiendas`
--
ALTER TABLE `tiendas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cate_carac`
--
ALTER TABLE `cate_carac`
  ADD CONSTRAINT `cate_carac_ibfk_2` FOREIGN KEY (`id_car`) REFERENCES `caracteristicas` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cate_carac_ibfk_3` FOREIGN KEY (`id_cat`) REFERENCES `categorias` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `producto_categoria`
--
ALTER TABLE `producto_categoria`
  ADD CONSTRAINT `producto_categoria_ibfk_1` FOREIGN KEY (`id_pro`) REFERENCES `productos` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `producto_categoria_ibfk_2` FOREIGN KEY (`id_cat`) REFERENCES `categorias` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `producto_tienda`
--
ALTER TABLE `producto_tienda`
  ADD CONSTRAINT `producto_tienda_ibfk_1` FOREIGN KEY (`id_tienda`) REFERENCES `tiendas` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `producto_tienda_ibfk_2` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `tiendaonline`
--
ALTER TABLE `tiendaonline`
  ADD CONSTRAINT `tiendaonline_ibfk_1` FOREIGN KEY (`id`) REFERENCES `tiendas` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
