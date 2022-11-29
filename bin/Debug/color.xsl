<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html">
	</xsl:output>
	<xsl:template match="/">
		<html>
			<body>
				<table border="1">
					<tr>
						<th>Назва</th>
						<th>Автор</th>
						<th>Рiк</th>
						<th>Факультет</th>
						<th>Анотацiя</th>
						<th>E-mail автора</th>
					</tr>
					<xsl:for-each select="database/resource">
						<tr>
							<td><font face="Arial" color="red" ><b>
								<xsl:value-of select="@title">
								</xsl:value-of>
                                                            </b></font>
							</td>
							<td><font color="navy">
								<xsl:value-of select="@author">
								</xsl:value-of>
                                                            </font>
							</td>
							<td><font color="brown">
								<xsl:value-of select="@year">
								</xsl:value-of>
                                                            </font>
							</td>
							<td><font color="oliva"><i>
								<xsl:value-of select="@faculty">
								</xsl:value-of>
                                                            </i></font>
							</td>
							<td>
								<xsl:value-of select="@annotation">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@email">
								</xsl:value-of>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>