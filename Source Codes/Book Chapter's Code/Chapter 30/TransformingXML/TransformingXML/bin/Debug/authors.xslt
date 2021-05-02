<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match ="/">
		<html>
			<head>
				<title>Authors</title>
			</head>
			<body>
				<table border ="1">
					<xsl:apply-templates/>
				</table>
			</body>
		</html>
		</xsl:template>
			<xsl:template match ="authorslist">
			<xsl:apply-templates select ="authors"/>
		</xsl:template>
		<xsl:template match ="authors">
			<tr>
				<td>
					<xsl:value-of select ="au_lname"/>
				</td>
				<td>
					<xsl:value-of select ="au_fname"/>
				</td>
			</tr>    
	</xsl:template>
</xsl:stylesheet>
