

import { useEffect, useState } from "react";
import { Product } from "../models/product";
import  Header  from "../layout/Header";
import  Catalog  from "../../features/catalog/Catalog";
import { Container, createTheme, CssBaseline, ThemeProvider, Typography } from "@mui/material";
import { dark } from "@mui/material/styles/createPalette";

function App() {
    const [darkMode, setDarkMode] = useState(false);
    const paletteType = darkMode ? 'dark' : 'light'
    const theme = createTheme({
        palette: {
            mode: paletteType,
            background: {
                default: paletteType === 'light' ? '#eaeaea' : '#121212'
            }
        }
    })
    function handleThemeChange() {
        setDarkMode(!darkMode);
    }
    return (
        <ThemeProvider theme={theme}>
            <CssBaseline />
            <Header darkMode={darkMode} handleThemeChange={handleThemeChange }/>
        <Container>
            <Catalog/>
        </Container>
        </ThemeProvider>
  );
}

export default App;
