"use client";
import Image from "next/image";
import { Inter } from "next/font/google";
import styles from "./page.module.css";
import React, { useState, useEffect } from "react";

const inter = Inter({ subsets: ["latin"] });

export default function Home() {
  const [data, setData] = useState([]);

  useEffect(() => {
    fetchData();
  }, []);
  async function fetchData() {
    const baseUrl = process.env.NEXT_PUBLIC_BASE_URL;
    const response = await fetch(`${baseUrl}/api/cat/catfact`);
    const json = await response.json();
    setData(json);
  }
  return (
    <main className={styles.main}>
      <h1>Cats Facts</h1>
      <h2 className={inter.className}>{data.fact} </h2>  
      <div className={styles.description}>
      
      
      </div>
      <div className={styles.grid}>
      <button className={styles.button} onClick={fetchData}>
          Click Me for New Fact
        </button>
      
      </div>
      <div className={styles.image}><Image
        src="/single-cat.png"
        alt="Example image"
        width={195}
        height={355}
      /></div>
      
     
    </main>
  );
}
