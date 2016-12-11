<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="text"/>

    <xsl:template match="/">
      <xsl:text>Statysyki miast:&#xA;&#xA;</xsl:text>
      <xsl:apply-templates select="/wypożyczalnia/statystyki/miasta/miasto"/>
      <xsl:text>Wypożyczenia:&#xA;&#xA;</xsl:text>
      <xsl:apply-templates select="/wypożyczalnia/wypożyczenia/wypożyczenie"/>
      <xsl:text>Autorzy:&#xA;&#xA;</xsl:text>
      <xsl:apply-templates select="/wypożyczalnia/autorzy/autor"/>
      <xsl:text>Data Raportu:</xsl:text>
      <xsl:apply-templates select="/wypożyczalnia/data_raportu"/>
    </xsl:template>

  <xsl:template match="/wypożyczalnia/statystyki/miasta/miasto">
    <xsl:value-of select="concat(nazwa,'&#xA;')" />
    <xsl:value-of select="concat('Liczba samochodów:&#x9;&#x9;',liczba_samochodow,'&#xA;')" />
    <xsl:value-of select="concat('Średnia cena wypożyczenia:&#x9;',średnia_cena_wypożyczenia,'&#xA;')" />
    <xsl:value-of select="concat('Średni przebieg:&#x9;&#x9;',średni_przebieg,'&#xA;')" />
    <xsl:value-of select="concat('Średni wiek:&#x9;&#x9;&#x9;',średni_wiek,'&#xA;&#xA;')" />
  </xsl:template>

  <xsl:template match="/wypożyczalnia/wypożyczenia/wypożyczenie">
    <xsl:value-of select="concat('Samochód:&#x9;&#x9;&#x9;',samochod,'&#xA;')" />
    <xsl:value-of select="concat('Pracownik:&#x9;&#x9;&#x9;',pracownik,'&#xA;')" />
    <xsl:value-of select="concat('Data wypożyczenia:&#x9;&#x9;',data_wypożyczenia,'&#xA;')" />
    <xsl:value-of select="concat('Data zwrotu:&#x9;&#x9;&#x9;',data_zwrotu,'&#xA;')" />
    <xsl:value-of select="concat('Wypożyczający:&#x9;&#x9;&#x9;',wypożyczający,'&#xA;&#xA;')" />
  </xsl:template>

  <xsl:template match="/wypożyczalnia/autorzy/autor">
    <xsl:value-of select="concat('Imie:&#x9;&#x9;&#x9;&#x9;',imie,'&#xA;')" />
    <xsl:value-of select="concat('Nazwisko:&#x9;&#x9;&#x9;',nazwisko,'&#xA;&#xA;')" />
  </xsl:template>

  <xsl:template match="/wypożyczalnia/data_raportu">
    <xsl:value-of select="concat('&#x9;&#x9;&#x9;',.,'&#xA;')" />
  </xsl:template>
</xsl:stylesheet>
