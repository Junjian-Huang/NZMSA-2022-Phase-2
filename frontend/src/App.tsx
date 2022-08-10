import axios from "axios";
import { useState } from "react";
import SearchIcon from "@mui/icons-material/Search";
import TextField from "@mui/material/TextField";
import "./App.css";
import { Box, Button, Grid, Paper, Skeleton } from "@mui/material";

function App() {
  const [pokemonName, setPokemonName] = useState("");
  const [pokemonInfo, setPokemonInfo] = useState<null | undefined | any>(
    undefined
  );
  const POKEMON_BASE_API_URL = "https://mhw-db.com/armor/";
  return (
    <div>
      <div className="search-field">
        <h1>Moster Hunter Weapen Search</h1>
        <div style={{ display: "flex", justifyContent: "center" }}>
          <TextField
            id="search-bar"
            className="text"
            value={pokemonName}
            onChange={(prop) => {
              setPokemonName(prop.target.value);
            }}
            label="Please input a number to see the change"
            variant="outlined"
            placeholder="Search..."
            size="medium"
          />
          <Button
            onClick={() => {
              search();
            }}
          >
            <SearchIcon style={{ fill: "blue" }} />
            Search
          </Button>
        </div>
      </div>

      {pokemonInfo === undefined ? (
        <div></div>
      ) : (
        <div
          id="Moster-result"
          style={{
            maxWidth: "800px",
            margin: "0 auto",
            padding: "100px 50px 60px 20px",
          }}
        >
          
            <Grid
              container
              direction="row"
              spacing={5}
              sx={{
                justifyContent: "center",
              }}
            >
              <Grid item>
                <Box>
                  {pokemonInfo === undefined || pokemonInfo === null ? (
                    <h1> Moster Hunter data not found.</h1>
                  ) : (
                    <div>
                      <p>
                        ID: {pokemonInfo.id}
                        <br />
                        Name: {pokemonInfo.name}
                        <br />
                        Rank: {pokemonInfo.rank}
                        <br />
                        Type: {pokemonInfo.type}
                        <br />
                        
                      </p>
                    </div>
                  )}
                </Box>
              </Grid>
              <Grid item>
                <Box>
                  {pokemonInfo?.name ? (
                   <div>
                    <p> Male :</p>
                   <img
                      height="200px"
                      width="200px"
                      alt={pokemonInfo.name}
                      src={pokemonInfo.assets.imageMale}
                    ></img>
                    </div>
                  ) : (
                    <Skeleton width={300} height={300} />
                  )}
                </Box>
              </Grid>
              <Grid item>
                <Box>
                  {pokemonInfo?.name ? (
                    <div>
                      <p>Feamal :</p>
                    <img
                      height="200px"
                      width="200px"
                      alt={pokemonInfo.name}
                      src={pokemonInfo.assets.imageFemale}
                    ></img>
                    </div>
                  ) : (
                    <Skeleton width={300} height={300} />
                  )}
                </Box>
              </Grid>
            </Grid>
          
        </div>
      )}
    </div>
  );

  function search() {
    console.log(pokemonName);
    if (pokemonName === undefined || pokemonName === "") {
      return;
    }

    axios
      .get(POKEMON_BASE_API_URL + pokemonName)
      .then((res) => {
        setPokemonInfo(res.data);
      })
      .catch(() => {
        setPokemonInfo(null);
      });
  }
}

export default App;