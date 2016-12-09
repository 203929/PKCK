<?xml version="1.0"?>
<xsl:stylesheet version="1.0"
		xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
		xmlns="http://www.w3.org/2000/svg"
		>
  <xsl:output
      method="xml"
      indent="yes"
      standalone="no"
      doctype-public="-//W3C//DTD SVG 1.1//EN"
      doctype-system="http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd"
      media-type="image/svg" />

  <xsl:template match="/">
    <svg xmlns="http://www.w3.org/2000/svg" width="500" height="500" >
      <rect x="0" y="0" width="500"
	    height="500" fill="grey"/>

      <xsl:apply-templates select="/wypożyczalnia/statystyki/miasta/miasto"/>
    </svg>
  </xsl:template>

  <xsl:template match="/wypożyczalnia/statystyki/miasta/miasto">
      <rect x="10" y="10" width="500"
	    height="200" fill="white" stroke="black"/>
  </xsl:template>
</xsl:stylesheet>