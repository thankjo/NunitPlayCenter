<?xml version="1.0" encoding="iso-8859-1"?>
<xsl:stylesheet
    version="1.0"
    exclude-result-prefixes="msxsl"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt"
>
  <xsl:output method="html" indent="yes"/>
  <xsl:template match="@* | node()">
    <html>
      <head>
        <!-- Latest compiled and minified CSS -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous"/>
        <!-- Optional theme -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous"/>
        <style type="text/css">
          .Passed { color: green; }
          .Inconclusive { color: #BBAA00; }
          .Failed { color: red; }
          ul {
          margin-left: 0px;
          list-style-type: none;
          padding-left: 0;
          }
          ul ul {
          margin-left: 15px;
          }
          label {
          font-weight: normal;
          }
          .counts {
          font-size: .7em;
          color: gray;
          }
        </style>
      </head>
      <body>
        <div class="container">
          <xsl:apply-templates select="/test-run/test-suite"/>
        </div>
        <!-- Latest compiled and minified JavaScript -->
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous">// Force closing tag</script>
        <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js">// Force closing tag</script>
        <script type="text/javascript">
          $("td label").each(function(i, e) {
          $(e).text($(e).text().replace(/_/g, " "));
          });
          $(".description").each(function(i, e) {
          $(e).html($(e).html().trim().replace(/\n/g, '<br/>'));
          });
        </script>
      </body>
    </html>
  </xsl:template>
  <xsl:template match="/test-run/test-suite">
    <h1>
      <xsl:value-of select="./test-run/@name"/>
    </h1>
    <table class="table table-striped">
      <xsl:apply-templates select="./test-suite"/>
    </table>
  </xsl:template>
  <xsl:template match="test-suite">
    <tr>
      <td>
        <xsl:attribute name="class">
          <xsl:choose>
            <xsl:when test="./@failed > 0">Failed</xsl:when>
            <xsl:when test="./@inconclusive > 0">Inconclusive</xsl:when>
            <xsl:otherwise>Passed</xsl:otherwise>
          </xsl:choose>
        </xsl:attribute>
        <xsl:attribute name="style">
          padding-left: <xsl:value-of select="count(ancestor::test-suite)*15"/>px;
        </xsl:attribute>
        <xsl:value-of select="./@name"/>
      </td>
      <td class="counts">
        <xsl:value-of select="./@passed"/> passed,
        <xsl:value-of select="./@inconclusive"/> inconclusive,
        <xsl:value-of select="./@failed"/> failed
      </td>
    </tr>
    <xsl:for-each select="./test-suite">
      <xsl:apply-templates select="."/>
    </xsl:for-each>
    <xsl:for-each select="./test-case">
      <xsl:sort select="./properties/property[@name='DocumentationOrder']/@value"/>
      <xsl:apply-templates select="."/>
    </xsl:for-each>
  </xsl:template>
  <xsl:template match="test-case">
    <tr>
      <td colspan="2">
        <xsl:attribute name="style">
          padding-left: <xsl:value-of select="count(ancestor::test-suite)*15"/>px;
        </xsl:attribute>
        <label>
          <xsl:attribute name="class">
            <xsl:value-of select="./@result"/>
          </xsl:attribute>
          <xsl:value-of select="./@name"/>
        </label>
        <xsl:if test="./properties/property[@name='Description']">
          <div class="description">
            <xsl:value-of select="./properties/property[@name='Description']/@value"/>
            <xsl:text> </xsl:text>
          </div>
        </xsl:if>
      </td>
    </tr>
  </xsl:template>
</xsl:stylesheet>